app.controller("stealApplesController", ["$http", "$scope", function ($http, $scope) {
    $scope.bushel = {};
    $scope.users = [];

    $http.get("/api/stealApples")
        .then(function (result) {
            $scope.bushels = result.data;
            console.log("result.data", result.data)
        })

    $scope.takeApples = function() {
        console.log("Click")
        }


}]);
