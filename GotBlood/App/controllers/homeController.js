app.controller("homeController", ["$scope", "$http", "$location", function ($scope, $http, $location) {

    $http.get("/api/values").then(function (result) {
        $scope.values = result.data;
    });

    $scope.message = "Hello World!!";
}]);
