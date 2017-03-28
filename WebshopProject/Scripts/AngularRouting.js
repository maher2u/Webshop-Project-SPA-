(function () {
    'use strict';

    var appRoute = angular.module('appRoute', [
        'ngRoute' // <-- This is needed to use AngularJS Routing!
    ]);

    appRoute.config(['$routeProvider', // <-- This is needed to use AngularJS Routing!
      function ($routeProvider) {
          $routeProvider.
            when('/', {
                templateUrl: '#/_main.html',
                controller: 'ShopController'
            }).
            otherwise({
                redirectTo: '/People'
            });
      }]);

})();