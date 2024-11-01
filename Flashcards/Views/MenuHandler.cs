using Spectre.Console;

namespace Flashcards.MenuHandler;

class MenuHandler
{

    internal enum MenuOptions
    {
        ManageStacks = 1,
        ManageFlashcards = 2,
        Study = 3,
        StudySessionData = 4,
        CloseApp = 5
    }
    internal MenuOptions ShowMenu()
    {
        Console.Clear();
        AnsiConsole.MarkupLine("[bold]Main Menu[/]");
        AnsiConsole.WriteLine();
        AnsiConsole.MarkupLine("[green](Use arrow keys to navigate, then press enter)[/]");
        AnsiConsole.WriteLine();
        var userSelection = AnsiConsole.Prompt(
            new SelectionPrompt<MenuOptions>()
                .Title("Select an option:")
                .AddChoices(
                    MenuOptions.ManageStacks,
                    MenuOptions.ManageFlashcards,
                    MenuOptions.Study,
                    MenuOptions.StudySessionData,
                    MenuOptions.CloseApp
                ));
        return userSelection;
    }
}