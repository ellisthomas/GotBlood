﻿app.controller("bloodBankController", ["$scope", "$http", "$location", function ($scope, $http, $location) {

    var flags = [
        ["Nashville Platelet", 36.156812, 86.807536],
        ["Nashville Blood", 36.156812, 86.807536],
        ["Nashville Zoo", 36.089195, -86.741524],
        ["Bridgestone Arena", 36.159174, -86.778496],
    ]

    $http.get("api/Account/BloodBanks").then(function (result) {
        $scope.banks = result.data;
    });

    $scope.drive;

    $scope.bloodDrive = () => {
        var drive = $scope.drive;
        console.log("$scope.drive", $scope.drive);
        $http({
            method: 'POST',
            url: "/api/BloodDrive",
            data: {
                Date: drive.Date,
                BloodDriveName: drive.BloodDriveName,
                BloodDriveStreetAddress: drive.BloodDriveCity,
                BloodDriveCity: drive.BloodDriveCity,
                BloodDriveState: drive.BloodDriveState,
                BloodDriveZip: drive.BloodDriveZip
            }
        })
            .then((result) => {
                resolve(result);
                console.log("result", result);
            }).catch((error) => {
                reject(error);
            });
    };

    //$http.get("api/BloodBanks").then(function (result) {
    //    $scope.drive = result.data;
    //});

}]);