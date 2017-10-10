app.controller("viewBushelsController",["$http","$scope",function($http, $scope) {
$scope.bushel = {};
$scope.users = [];

$http.get("/api/viewBushels")
    .then(function (result) {
        $scope.bushels = result.data;
        console.log("result.data", result.data)
    })

/*
$scope.pickApples = function () {
    let bushel = $scope.bushel;
    $http.post("/api/PickApples",
        {
            Type: bushel.appleType,
            NumberOfBushels: bushel.numberOfBushels,
            UserId: bushel.userId
        })
        .then(result => console.log(result))
        .catch(error => console.log(error));
};
    */

}]);