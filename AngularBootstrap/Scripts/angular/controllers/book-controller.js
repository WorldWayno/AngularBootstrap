(function() {
    var app = angular.module("app");

    app.controller("BookController", function($scope) {
        $scope.toolbox = "MY TOOLBOX";
        $scope.canvas = "MY CANVAS";

        $scope.tabs = [
            { title: "Sections", content: "Dynamic content 1", disabled: false },
            { title: "Settings", content: "Dynamic content 2", disabled: false }
        ];

        $scope.navType = "pills";

        $scope.oneAtATime = true;
    })
})();