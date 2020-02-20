package com.frc3175.scoutcompanionapp;

import android.os.Environment;

import com.thebluealliance.api.v3.TBA;
import com.thebluealliance.api.v3.models.Match;
import com.thebluealliance.api.v3.models.SimpleMatch;
import com.thebluealliance.api.v3.models.SimpleTeam;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;

public class Event {

    public String eventKey;
    private com.thebluealliance.api.v3.models.Event event;
    private Match[] matches;
    private String eventName;
    private ArrayList<Integer> teamList;
    private ArrayList<MyMatch> matchList;


    public Event(TBA tba, String eventKey) {
        try {

            this.eventKey = eventKey;
            this.teamList = new ArrayList<>();
            this.matchList = new ArrayList<>();
            this.eventName = tba.eventRequest.getSimpleEvent(eventKey).getName();
            SimpleTeam[] teams = tba.eventRequest.getSimpleTeams(eventKey);
            for (int i = 0; i < teams.length; i++) {
                this.teamList.add(teams[i].getTeamNumber());
            }
            SimpleMatch[] matches = tba.eventRequest.getSimpleMatches(eventKey);
            for (int i = 0; i < matches.length; i++) {
                // if (matches[i].getCompLevel() == "qm") {
                MyMatch match = new MyMatch(matches[i]);
                this.matchList.add(match);
                //   }
            }
            orderMatches();

        }
        catch (Exception e) {
            System.out.println(e.toString());
            System.out.println("Error, event doesn't exist. Please try a new event name.");
        }

    }

    private void orderMatches() {
        ArrayList<MyMatch> newList = new ArrayList<>();
        while (matchList.size() > 0) {
            MyMatch x;
            x = matchList.get(0);
            for (int i = 0; i < matchList.size(); i++) {
                if (x.matchNum > matchList.get(i).matchNum){
                    x = matchList.get(i);
                }
            }
            newList.add(x);
            matchList.remove(x);
        }
        this.matchList = newList;
    }

    public String getEventName() {
        return this.eventName.toString();
    }

    private void orderTeamList() {
        ArrayList<Integer> newList = new ArrayList<>();
        while (teamList.size() > 0) {
            int x;
            x = teamList.get(0);
            for (int i = 0; i < teamList.size(); i++) {
                if (x > teamList.get(i)){
                    x = teamList.get(i);
                }
            }
            newList.add(x);
            teamList.remove(teamList.indexOf(x));
        }
        this.teamList = newList;

    }

    public boolean printTeamList() {
        orderTeamList();
        File dir = Environment.getExternalStoragePublicDirectory(Environment.DIRECTORY_DOCUMENTS);
        File file = new File(dir,"/FRC2020Scout/teamlist.txt");
        try {
            file.getParentFile().mkdirs();
            file.delete();
            file.createNewFile();
            String line = "";
            FileWriter fw = new FileWriter(file);
            PrintWriter pw = new PrintWriter(fw);
            for (int i=0;i<this.teamList.size();i++) {
                line = teamList.get(i).toString() + "\r";
                pw.println(line);
            }
            pw.close();
            System.out.println("successfully exported");
            return true;
        }
        catch (IOException e) {
            e.printStackTrace();
            System.out.println("die dumbass");
            return false;
        }
    }

    public boolean genMatchList() {
        File dir = Environment.getExternalStoragePublicDirectory(Environment.DIRECTORY_DOCUMENTS);
        File file = new File(dir, "/FRC2020Scout/matchlist.txt");
        try {
            file.getParentFile().mkdirs();
            System.out.println(file.getAbsolutePath());
            file.delete();
            file.createNewFile();
        } catch (IOException e) {
            e.printStackTrace();
        }
        try {
            String line = "";
            FileWriter fw = new FileWriter(file);
            PrintWriter pw = new PrintWriter(fw);
            for (int i=0;i<this.matchList.size();i++) {
                if (this.matchList.get(i).compLevel.contains("qm")) {
                    line = matchList.get(i).exportMatch() + "\r";
                    //wrtieFileOnInternalStorage(,"matchlist.txt", line);
                    pw.println(line);
                }
            }
            pw.close();
            return true;
        }
        catch (IOException e) {
            e.printStackTrace();
            return false;

        }
    }

}


