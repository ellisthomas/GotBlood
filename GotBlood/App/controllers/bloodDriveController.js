app.controller("bloodDriveController", ["$scope", "$http", "$location", function ($scope, $http, $location) {

    $scope.bloodDrive = () => {
        var drive = $scope.drive;
        $http({
            method: 'POST',
            url: "/api/Account/BloodDrive/Community",
            data: {
                Location: drive.Location,
                Date: drive.Date
            }
        }).then(function (result) {
            $location.path("/");
        });
    }
}]);