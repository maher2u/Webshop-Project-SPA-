var app = angular.module("shopApp", ["ngRoute"]);
app.config(function ($routeProvider) {
    $routeProvider
    .when("/", {
        templateUrl: "/Products/Start"
    })
    .when("/1", {
        templateUrl: "/Products/Product1"
    })
    .when("/2", {
        templateUrl: "/Products/Product2"
    })
    .when("/3", {
        templateUrl: "/Products/Product3"
    });
});