function PhoneListCtrl($scope, $http) {

    $http.get('/Content/phones/phones.txt').success(function (data) {
        $scope.phones = data;
    });

    $scope.hello = "Hello world!";

    $scope.helloName = function (name) {
        return "Hello " + name;
    };

    $scope.orderProp = "name";
}

function PhoneDetailCtrl($scope, $routeParams, $http) {
    //alert('/Content/phones/' + $routeParams.phoneId + '.json');
    $http.get('/Content/phones/' + $routeParams.phoneId + '.json').success(function (data) {
        $scope.phone = data;
    });
}