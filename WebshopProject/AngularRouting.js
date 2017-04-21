var app = angular.module("shopApp", ["ngRoute"]);
app.config(function ($routeProvider) {
    $routeProvider
    .when("/", {
        templateUrl: "/Products/Start"
    })
    .when("/JL", {
        templateUrl: "/Products/JL"
    })
    .when("/2", {
        templateUrl: "/Products/Product2"
    })
    .when("/top-2017", {
        templateUrl: "/Products/Top2017"
    });
});