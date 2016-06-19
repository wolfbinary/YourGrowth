class ExerciseProgramsUI {
    static initializeTab() {
        $("#adminRoutinesToUse, #adminRoutinesUsed").sortable({
            connectWith: ".connectedSortable"
        }).disableSelection();
    }
}