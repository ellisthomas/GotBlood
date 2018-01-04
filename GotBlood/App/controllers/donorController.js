app.controller("donorController", ["$scope", "$http", "$location", function ($scope, $http, $location) {

    $http.get("/api/Account/UserInfo").then(function (result) {
        $scope.users = result.data;
    });

}]);


