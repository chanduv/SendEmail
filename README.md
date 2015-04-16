# SendEmail
TestApp to send emails via Send grid
This check-in contains a project which sends out email using SendGrid.
Ideally i would have the Email class in a nuget package, so that it can
be re used across multiple projects.
Also, wouldnt it be better if the client doesn't know how or who sends
the email.. example: should the client know if the email is being sent
via sendgrid or exact target?

- May be yes, because the Client 'buys' the subscription with the email
provider. :)
- Having the interface makes it easier for the client, so the client
doesn't have to change the application, Just add the new class that uses
a new email provider.
