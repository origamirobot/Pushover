# Pushover
I needed a way to send Pushover notifications from the command line to easily see when my backups finish. This is a small command line
application that does just that.

## Usage

```
pushover.exe -m "The message to send to pushover" -a "PushoverApplicationToken" -u "PushoverUserKey"
```

## Dependencies

This application has a single dependency on	[NDesk.Options](http://www.ndesk.org/Options) for parsing command line options.




