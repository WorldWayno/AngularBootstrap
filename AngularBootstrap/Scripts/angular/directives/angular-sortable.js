'use strict';

app.directive('myDatepicker', function ($parse, $log) {
    return {
        restrict: "E",
        replace: true,
        transclude: false,
        compile: function (element, attrs) {
            var modelAccessor = $parse(attrs.ngModel);
            $log.info('model', modelAccessor);

            var html = "<input type='text' id='" + attrs.id + "' >" +
               "</input>";

            var newElem = $(html);
            element.replaceWith(newElem);

            return function (scope, element, attrs, controller) {

                var processChange = function () {
                    var date = new Date(element.datepicker("getDate"));
                    $log.info('date', date);
                    scope.$apply(function (scope) {
                        // Change bound variable
                        modelAccessor.assign(scope, date);
                    });
                };

                element.datepicker({
                    showOn: 'both',
                    autoSize: true,
                    inline: true,
                    onClose: processChange,
                    onSelect: processChange
                });

                scope.$watch(modelAccessor, function (val) {
                    var date = new Date(val);
                    $log.info('watch', date);
                    element.datepicker("setDate", date);
                });

            };

        }
    };
});
