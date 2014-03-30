
var app = angular.module("app", ["xeditable", "ngDragDrop"]);

app.run(function(editableOptions) {
    editableOptions.theme = 'bs3';
})