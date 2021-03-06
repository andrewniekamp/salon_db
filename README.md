# Salon Database App

##### By Andrew Niekamp

## Description

_Web app using a database to store user-added clients and stylists._

## Setup/Installation

_Files can be cloned from https://github.com/andrewniekamp/salon_db.git and run in a browser (requires a server environment)._

_Using Mono in the root directory, type the following at the command prompt:

_To install dependencies:_

\>dnu restore

_To use the database, in SQLCMD:_

\>CREATE DATABASE hair_salon;

\>GO

\>USE hair_salon;

\>GO

\>CREATE TABLE stylists (id INT IDENTITY (1,1), first_name VARCHAR(255), last_name VARCHAR(255), expertise VARCHAR(255));

\>CREATE TABLE clients (id INT IDENTITY (1,1), first_name VARCHAR(255), last_name VARCHAR(255), stylist_id INT);

\>GO

_To run the local server:_

\>dnx kestrel

_Navigate to http://localhost:5004 in your browser._

## Known Bugs

_None known._

## Technologies Used

_C#, Razor, Nancy, HTML, CSS, Xunit_

### License

Copyright (c) 2016 Andrew Niekamp

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
