'use strict';

app.controller("BookController", function ($scope, $timeout, $log) {

    var sortableEle;

    $scope.date = new Date(1970, 3, 2);

    $scope.cols = [{ id: 1, title: '' }];

    $scope.sections = [{ id: 1, title: 'Section' }];

    $scope.hideMe = function() {
        return $scope.sections.length > 0;
    }

    $scope.optionsList1 = {
        accept: function(dragEl) {
            if ($scope.list1.length >= 2) {
                return false;
            } else {
                return true;
            }
        }
    };

    $scope.addCol = function() {
        $scope.cols.push({ id: $scope.cols.length + 1, title: '' });
        sortableEle.sortable('refresh');
    }

    $scope.removeCol = function(index) {
        $log.info("index", index);
        $scope.cols.splice(index, 1);
    }

    $scope.dragHelper = function(el) {
        $log.info('drag helper', el)
        return "<input type='text'/>";
    }

    $scope.dragStart = function(e, ui) {
        ui.item.data('start', ui.item.index());
        var col = $scope.cols[ui.item.index()];
        col.index = ui.item.index();
        $log.info('start', $scope.cols[ui.item.index()]);


    }

    $scope.dragEnd = function(e, ui) {
        var start = ui.item.data('start'),
            end = ui.item.index();

        $scope.cols.splice(end, 0,
            $scope.cols.splice(start, 1)[0]);

        $scope.$apply();
    }

    // init

    sortableEle = $("#sortable").sortable({
        start: $scope.dragStart,
        update: $scope.dragEnd
    });

});