angular.module('phonecat', ['phonecatFilters']).
  config(['$routeProvider', function ($routeProvider) {
      $routeProvider.
          when('/phones', { templateUrl: 'PhoneList', controller: PhoneListCtrl }).
          when('/phones/:phoneId', { templateUrl: 'PhoneDetail', controller: PhoneDetailCtrl }).
          otherwise({ redirectTo: '/phones' });
  }]);

