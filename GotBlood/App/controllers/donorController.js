app.controller("donorController", ["$scope", "$http", "$location", function ($scope, $http, $location) {

    $http.get("/api/values").then(function (result) {
        $scope.values = result.data;
    });

    $scope.message = "Hello World!!";
}]);


//app.controller("donorController", ["$rootScope", "$scope", "$http", "$location", function ($rootScope, $scope, $http, $location) {


//    $scope.GetUserInfo = () => {
//        $http({
//            method: 'Post',
//            url: "api/Account/UserInfo",
//            data: {
//                UserName: auth.username,
//                Password: auth.password,
//                confirmPassword: auth.confirm,
//                Email: auth.email,
//                Phone: auth.phone,
//                Location: auth.location,
//                Address: auth.address,
//                FirstName: auth.firstName,
//                LastName: auth.lastName,
//                Birthdate: auth.birthdate
//            }
//        }).then((resultz) => {
//            resolve(resultz);
//            //$location.path("/");
//            console.log("resultz", resultz);
//        }).catch((error) => {
//            reject(error);
//        });
//    }



//}]);