
var app = angular.module("app", ["ui.bootstrap", "xeditable"]);

app.run(function(editableOptions) {
    editableOptions.theme = 'bs3';
})