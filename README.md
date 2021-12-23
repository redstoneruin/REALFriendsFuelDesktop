# REALFriendsFuelDesktop
Desktop version of the [REAL Friend Fuel Calculator](https://realfriendsracing.com/calculator) website with telemetry logging.

### Building
Build with visual studio, relies on the [iRacingSDK.Net](https://github.com/vipoo/iRacingSDK.Net) library.

### Usage
The calculator can be used without iRacing by simply inputting values. The app uses a telemetry thread to continuously search for connection to iRacing, and log lap information once connected. The logged laps can then be fed into the calculator using the grab buttons.
