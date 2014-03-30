(function() {
    var app = angular.module("app", ['builder', 'builder.components', 'validator.rules']);

    app.controller('DemoController', function ($scope, $builder, $validator) {
    var checkbox, textbox;
    textbox = $builder.addFormObject('default', {
      component: 'textInput',
      label: 'Name',
      description: 'Your name',
      placeholder: 'wayno',
      required: false,
      editable: true
    });
    checkbox = $builder.addFormObject('default', {
      component: 'checkbox',
      label: 'Pets',
      description: 'Do you have any pets?',
      options: ['Dog', 'Cat']
    });
    $scope.form = $builder.forms['default'];
    $scope.input = [];
    $scope.defaultValue = {};
    $scope.defaultValue[textbox.id] = 'default value';
    $scope.defaultValue[checkbox.id] = [true, true];
    return $scope.submit = function() {
      return $validator.validate($scope, 'default').success(function() {
        return console.log('success');
      }).error(function() {
        return console.log('error');
      });
    };
  });

}).call(this);
