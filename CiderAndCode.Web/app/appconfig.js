app.config(["$routeProvider",function($routeProvider) {
    $routeProvider
        .when("/pickapples",
        {
                templateUrl: "/app/views/PickApples/pickApples.html",
                controller: "pickApplesController"
        })
        .when("/stealapples",
        {
            templateUrl: "/app/views/StealApples/stealApples.html",
            controller: "stealApplesController"

        })
        .when("/viewbushels",
        {
            templateUrl: "/app/views/ViewBushels/viewBushels.html",
            controller: "viewBushelsController"

        })
        ;
}]);