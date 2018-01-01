app.controller("bloodBankController", ["$scope", "$http", "$location", function ($scope, $http, $location) {

    var drives = [
        ["Nashville Platelet", 36.156812, 86.807536],
        ["Nashville Blood", 36.156812, 86.807536],
        ["Nashville Zoo", 36.089195, -86.741524],
        ["Bridgestone Arena", 36.159174, -86.778496 ],
    ]

    $http.get("api/Account/BloodBanks").then(function (result) {
        $scope.banks = result.data;
    });

    $scope.bloodDrive = () => {
        var drive = $scope.drive;
        $http({
            method: 'POST',
            url: "/api/Account/Register",
            data: {
                UserName: auth.username,
                Password: auth.password,
                confirmPassword: auth.confirm,
                Email: auth.email,
                Phone: auth.phone,
                Location: auth.location,
                Address: auth.address,
                FirstName: auth.firstName,
                LastName: auth.lastName,
                Birthdate: auth.birthdate,
                Type: auth.bloodType
            }
        })

}]);