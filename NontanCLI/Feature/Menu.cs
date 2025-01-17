﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace NontanCLI.Feature
{
    internal class MenuHandler
    {
        [Obsolete]
        public static string MenuHandlerInvoke()
        {

            // figlet 

            AnsiConsole.Write(
                new FigletText("NontanCLI")
                    .LeftJustified()
                    .Color(Color.Yellow));

            AnsiConsole.MarkupLine("[bold yellow]Welcome to NontanCLI[/]");
            AnsiConsole.MarkupLine("[bold white]A Simple Console App for streaming Anime[/]");
            AnsiConsole.MarkupLine("[bold white]Made with Love by evnx32[/]");
            // version

            AnsiConsole.MarkupLine($"[bold white]Version :[/] [bold green]{Program.version}[/]" + $" ({Program.buildVersion})\n\n");

            var _prompt = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("[green]Select Menu Available[/]?")
                .PageSize(10)
                .MoreChoicesText("[grey](Move up and down to reveal more menu)[/]")
                .AddChoices(new[] {
                    "Popular","Trending", "Search","Exit"
                }));

            return _prompt;
        }
    }
}
