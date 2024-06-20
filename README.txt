2024-06-18
﻿Group Name: OMICRON
Course code:CYB206
Group Members: Matthew Gabrielle
			   Sameerkumar Barot
		       Vinay kumar Chepuri
2230
Web app create w/ VS2022 .NET'/
No auth........
SSL cert SH-1
Created README.txt
Ran the program, confiremed that web page open properly without any error.
we just go Views>Home>index.cshtml and change header welcome with "MvcMovies"
and ran program in 3 differnt browsers Chrome,Firefox and Ms edge.
URL:https://localhost:7256/

2240
Added controller
Completed part 2
after successfully ran part 1 and moving forward to Add controllers MvcMovies>Controllers>MvcMovies.cs

	//What is Controllers ?
		Classes that:
		Handle browser requests.
		Retrieve model data.
		Call view templates that return a response.
	we Create new controller "MvcMovie.cs"
	add namespace MvcMovie.controller
	and we used public method in controller because it can handle incoming HTTP and HTTPS request.we tried other method like Private and Projected that are not meant to handle HTTP requests. 
    from online resources private and projected methods are used for internal logic and helper functions.

	we Created two public string "Index" and "welcome"
	and make sure confirm again 
2250 
Now we tried to modify a code and pass some parameter information from the URl
	we created Public string Welcome and add 2 parameters
		string "name"
		integer "numTimes"
	and this time i used HtmlEncoder to encode protentially dangerous characters in user input,avoid XSS attacks and Java code injections.

2255 (	we just started Part 3 that edit views part.)
Added view
Right-click on the Views folder, and then Add > New Folder and name the folder
ight-click on the Views/MvcMovies folder, and then Add > New Item.
Views/Shared/_Layout.cshtml
Open the Views/Shared/_Layout.cshtml file.
In the Add New Item - Furnitures dialog:
	we tried to change layout of web page
	add header "h2"
	create _Layout.cshtml


2330
Added model

2024-06-19
0640
Created database

0750
Created database
