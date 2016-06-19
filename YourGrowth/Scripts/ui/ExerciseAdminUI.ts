class ExerciseAdminUI {
    static initializeTabs() {
        $("#adminExerciseTabs").tabs();

        ExerciseProgramsUI.initializeTab();
        ExerciseRoutinesUI.initializeTab();
    }
}