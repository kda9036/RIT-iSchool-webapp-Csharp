Kelly Appleton
ISTE-340: Client Programming
Project 3: Consume a Web Service
12/7/2022

README

About the project:

Creation of a website for the RIT iSchool.
C# front-end that accesses RESTful services.
API: http://www.ist.rit.edu/api/
•	About, Degrees, Minors, Employment, People, Courses on demand
Conversion of JSON to C# classes: https://json2csharp.com/
jQuery plugins for UI.

Created website theme using https://jqueryui.com/themeroller/
- Custom theme creation using RIT brand colors

About the project/plugins by page:

About:
Minimal Any Content Slideshow Plugin - Recursive Content Rotator
https://www.jqueryscript.net/slideshow/recursive-content-rotator.html 
- Image carousel

Degrees:
Accordion
https://jqueryui.com/accordion/
Also accounted for if concentrations and available certificates attributes existed
and only displayed them if they did.

Minors:
Nested Modal Windows With Blurred Background - JQuery Modally
https://www.jqueryscript.net/lightbox/nested-modal-modally.html
- First popup to display information about a minor
- Second popup to display courses for the minor
- Challenge to nest modals inside a foreach loop.  Had to create IDs dynamically and
manipulate the jQuery function(s)
Some button styling added with bootstrap.

Course:
Some course titles formatted "&" as "&amp;" and this was accounted for using an if/else
statement, .Contains(), and .Replace()

Employment:
jQuery Flip
http://nnattawat.github.io/flip/
- Flip cards to reveal information about degree statistics
Data Tables
https://datatables.net/
- Tables for Co-ops and Employment
- Styled tables with CSS

People:
Tabs and Dialog
https://jqueryui.com/demos/
- Challenge to nest modals inside a foreach loop.  Had to create IDs dynamically and
manipulate the jQuery function(s).  Had to associate correct button with correct dialog to open.
- Less clutter by using dialog to show additional information about each person.
Also accounted for if certain attributes did or did not exist to display or not.

Additional Notes:
Additional manipulation to the People page (beyond what was completed in class).
site.js - added some "options" to jQuery functions.
- Example: Looked up API documentation and added "modal: true" to disable
other items on the page when a dialog pops up.
Added CSS styling in site.css and some inline styling.
- Some difficulties with the theme conflicting with site.css and lib CSS files. Had to
manipulate some of the CSS from plugin/widget downloads.
Due to custom theme, "x" / Close button on the people dialog popups is not visible and the
white box where the Close button would be must be clicked to close the dialog.
RIT tiger logo added to Welcome/Index page and additional RIT images added to About page
via a jQuery slideshow.
Background image manipulated using Adobe Illustrator and applied to the entire website.