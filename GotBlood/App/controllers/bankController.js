app.controller("bankController", ["$scope", "$http", "$location", function ($scope, $http, $location) {

    $http.get("api/Account/BloodBanks").then(function (result) {
        $scope.banks = result.data;
    });

}]);


