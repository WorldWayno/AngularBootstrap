
var app = angular.module("app", ["xeditable", "ngDragDrop", "infinite-scroll"]);

app.run(function(editableOptions) {
    editableOptions.theme = 'bs3';
})