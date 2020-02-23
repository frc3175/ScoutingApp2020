# ScoutingApp2020
[Our 2020 scouting app, available for all](https://github.com/frc3175/ScoutingApp2020/releases)

## These are the instructions for being able to use our FRC 2020 Scouting App.

This scouting system requires Windows OS with Excel (This was created on Excel 2016) and an Android device with internet connectivity.

This app was created with event management in mind, meaning it does not use any Wi-Fi, it only uses Ethernet enabled networks,
(or a flash drive), and a 1-time use app so you do not need a constant internet connection.

Download the "FRC 2020 Scouting App Companion" app from the Google Play Store on a mobile data enabled Android device.

Find your event key on The Blue Alliance (Tip: Go to the event page, and the characters after "/event/" in the URL are the event key.)

Put the event key into the [FRC 2020 Scouting App Companion](https://play.google.com/store/apps/details?id=com.frc3175.scoutcompanionapp) and hit "Download Match Schedules". Give the app permission to write to storage. If it says "Success!", you are good to go!

Connect the Android device to the lead scout laptop, and extract the files generated from the Documents/FRC2020Scout folder, and 
place them in the home directory (/FRC 2020 Scouting App/).

Once these things are done, you may begin scouting! Open up the "FRC 2020 Scouting Form.exe" file, and all the work of figuring out what
scout has to do what team is taken care of, you just have to assign an alliance station to them, and it tells them what robot to scout, and it auto counts to the next match. (It allows you to change for new days of scouting as well as in case of a replay).

Another option is to download the [FRC 2020 Scout app onto an Android enabled device](https://play.google.com/store/apps/details?id=com.frc3175.scout2020), and scout matches using that. Be aware that you <b>MUST</b> use the companion app first as well to download match schedules, otherwise the app will not work.

If you are using multiple devices, and would like to pull in data, run the MergeDataFiles.exe on the machine you would like the data to  be collected on, then select the file on the non-host device, and it will merge the files.

Once you have scouted a few matches, you might want to look at data! Open the Excel file, and hit the <b>Load Data</b> button. It will generate individual scouting reports for every team at the event, as well as a full event breakdown. (If you do this before you download match schedules and team list, go to cell B7 on the HOME sheet and change the value from 0 to 1, then re-run the load. Do NOT do that if you have already generated the scouting reports once. The sheets will automatically update.)

I recommend using the <b>Event Data</b> tab to help you plan your alliance selection, it has sorts for Averages, MAX, MIN, Median, and 
standard deviation for stats where it is applicable, and allows you to filter out teams that have been selected as alliance selection 
progresses.

## Good luck in your events!
