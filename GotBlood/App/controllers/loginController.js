app.controller("loginController", ["$rootScope", "$scope", "$http", "$location", function ($rootScope, $scope, $http, $location) {
    $scope.username = "";
    $scope.password = "";
    $rootScope.currentToken = "";
    $scope.auth = {};
    $scope.userLogin = {};
    $scope.alerts = [];

    $scope.login = function () {
        $scope.error = "";
        $scope.inProgress = true;
        $http({
            method: 'POST',
            url: "/Token",
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
            transformRequest: function (obj) {
                var str = [];
                for (var p in obj)
                    str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
                return str.join("&");
            },
            data: { grant_type: "password", username: $scope.userLogin.username, password: $scope.userLogin.password }
        })
            .then(function (result) {
                sessionStorage.setItem('token', result.data.access_token);
                currentToken = sessionStorage.getItem('token');
                $http.defaults.headers.common['Authorization'] = `bearer ${result.data.access_token}`;
                $location.path("/");

                $scope.inProgress = false;
            }, function (result) {
                $scope.error = result.data.error_description;
                $scope.inProgress = false;
            });


    };

    $scope.registerUser = () => {
        var auth = $scope.auth;
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
                Birthdate: auth.birthdate
            }
        })
            .then(function (result) {
                sessionStorage.setItem('token', result.data.access_token);
                currentToken = sessionStorage.getItem('token');
                $http.defaults.headers.common['Authorization'] = `bearer ${result.data.access_token}`;
                $location.path("/");

                $scope.inProgress = false;
            }, function (result) {
                $scope.error = result.data.error_description;
                $scope.inProgress = false;
            });
            //.then((resultz) => {
            //    resolve(resultz);
            //    $location.path("/");
            //    console.log("resultz", resultz);
            //}).catch((error) => {
            //    reject(error);
            //});
    };

}]);