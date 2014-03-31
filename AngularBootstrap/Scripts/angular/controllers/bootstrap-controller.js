
app.controller("BootstrapController", function($scope, $timeout, $log) {

    var sortableEle;

    $scope.test = 'Hello World';

    $scope.rows = [];

    $scope.dragStart = function (e, ui) {
        ui.item.data('start', ui.item.index());
        var col = $scope.rows[ui.item.index()];
        col.index = ui.item.index();
        $log.info('start', $scope.rows[ui.item.index()]);
    }

    $scope.dragEnd = function (e, ui) {

        $log.info('e:', e);
        $log.info('ui.item:', ui.item);
        var scope = angular.element(ui.item).scope().test;

        angular.element(ui.item).scope().$apply();

        $log.info('scope', scope);

        var start = ui.item.data('start'),
            end = ui.item.index();

        $scope.rows.splice(end, 0,
            $scope.rows.splice(start, 1)[0]);

        $log.info('end', end);

        $scope.$apply();
    }


    //init

    sortableEle = $("#sortable").sortable({
        start: $scope.dragStart,
        update: $scope.dragEnd
    });
})