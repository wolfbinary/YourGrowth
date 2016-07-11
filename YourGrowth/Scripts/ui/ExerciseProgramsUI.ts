/// <reference path="../typings/jquery/jquery.d.ts" />
class ExerciseProgramsUI {
    static initializeTab() {
        $("#adminRoutinesToUse, #adminRoutinesUsed").sortable({
            connectWith: ".connectedSortable"
        }).disableSelection();
    }
}