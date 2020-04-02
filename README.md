# Webanalyse im Einklang mit der DSGVO

## Kurzbeschreibung

Im Zuge einer Diplomarbeit soll von 3 Schülern der HTL Grieskirchen evaluiert werden, wie man unter Einhaltung der DSGVO Benutzeranalysen auf Holter Online betreiben kann und die Unterschiede der hierfür möglichen Tools hervorgehoben werden.

Um den Umfang entsprechend gestalten zu können, soll die Diplomarbeit nicht direkt anhand von Holter Online erarbeitet werden, sondern hierfür basierend auf der Holter Open Data Schnittstelle eine eigene Webseite unter Verwendung von Blazor entwickelt werden.

### Team

* Sebastian Kronschläger - sebastian.kronschlaeger@gmail.com
* Florian Eggetsberger - florian.eggetsbergerfefe@gmail.com
* Lukas Humer - lukashumer2002@gmail.com

### Ansprechpartner bei Holter

* Andreas Binder - andreas.binder@holter.at
* Barbara Habitzl - barbara.habitzl@holter.at
* Patrick Hrastnik - patrick.hrastnik@holter.at

## Webanalyse Tools

Das wohl bekannteste Tool für Webanalyse ist Google Analytics: https://analytics.google.com/
Bei Google Analytics ist aber seitens unseres Datenschutzbeauftragten bei Holter die Meinung fest verankert, dass es hier Probleme mit dem Einhalten der DSGVO gibt. Eine laut seiner Ansicht nach bessere Alternative wäre Matomo: https://matomo.org/

## Webshop

Der Webshop wird vom Team unter Verwendung von Blazor entwickelt. So fern eine serverseitige Komponente benötigt wird, steht es dem Team hier frei, welche Technologie hierfür eingesetzt wird.

Informationen zu Blazor: https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor

## Holter Open Data Schnittstelle

Der Webshop kann auf Basis unserer Holter Open Data Schnittstelle entwickelt werden. Diese Schnittstelle bietet alle notwendigen Webservices für

* Login
* Warenkorb erstellen
* Artikelsuche
* Artikeldetailansicht
* Artikel zu Warenkorb hinzufügen
* Warenkorb bestellen

Die Details zu den jeweiligen Webservices und eine vollständige Auflistung findet man in der Spezifikation zur [Holter Open Data Schnittstelle](./doc/Holter%20Open%20Data%20V3.1.pdf).

## Ziele der Diplomarbeit

Das oberste Ziel dieser Diplomarbeit ist die Evaluierung der Webanalyse Tools, deren Gegenüberstellung und wie diese Tools eingesetzt werden können, ohne gegen die DSGVO zu verstoßen. Das für Holter am besten passende Tools wird nämlich in weiterer Folge in den Webshop *Holter Online*, sowie die in Arbeit befindliche neue Holter Webseite eingebaut.

Darüber hinaus ist es für Holter natürlich auch höchst interessant einen tieferen Einblick in die Entwicklung mit Blazor zu erhalten. Neue Technologien in der Softwareentwicklung können leider im Arbeitsalltag nicht immer im Detail evaluiert werden, weshalb wir dies gerne im Zuge dieser Diplomarbeit behandeln möchten. Dadurch erhoffen wir uns Informationen um den Reifegrad von Blazor, also ob der professionelle Einsatz für geschäftskritische Anwendungen bereits möglich ist.