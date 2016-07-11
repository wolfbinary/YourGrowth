var ExerciseAdminUI = (function () {
    function ExerciseAdminUI() {
    }
    ExerciseAdminUI.initializeTabs = function () {
        $("#adminExerciseTabs").tabs();
        ExerciseProgramsUI.initializeTab();
        ExerciseRoutinesUI.initializeTab();
    };
    return ExerciseAdminUI;
})();
