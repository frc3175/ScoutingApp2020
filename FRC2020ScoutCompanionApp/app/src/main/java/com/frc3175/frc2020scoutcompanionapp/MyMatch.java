package com.frc3175.frc2020scoutcompanionapp;

import com.thebluealliance.api.v3.models.SimpleMatch;

public class MyMatch {
    public int matchNum;
    private int red1;
    private int red2;
    private int red3;
    private int red4;
    private int blue1;
    private int blue2;
    private int blue3;
    private int blue4;
    public String compLevel;
    private int tPA;


    //normal match constructor
    public MyMatch(int matchNum, int red1, int red2, int red3, int blue1, int blue2, int blue3) {
        this.matchNum = matchNum;
        this.red1 = red1;
        this.red2 = red2;
        this.red3 = red3;
        this.red4 = -1;
        this.blue1 = blue1;
        this.blue2 = blue2;
        this.blue3 = blue3;
        this.blue4 = -1;
        this.tPA = 3;

    }

    //for 4 team alliances (championships and certain offseasons)
    public MyMatch(int matchNum, int red1, int red2, int red3, int red4, int blue1, int blue2, int blue3, int blue4) {
        this.matchNum = matchNum;
        this.red1 = red1;
        this.red2 = red2;
        this.red3 = red3;
        this.red4 = red4;
        this.blue1 = blue1;
        this.blue2 = blue2;
        this.blue3 = blue3;
        this.blue4 = blue4;
        this.tPA = 4;

    }

    //FTC 2 teams per alliance
    public MyMatch(int matchNum, int red1, int red2, int blue1, int blue2) {
        this.matchNum = matchNum;
        this.red1 = red1;
        this.red2 = red2;
        this.red3 = -1;
        this.red4 = -1;
        this.blue1 = blue1;
        this.blue2 = blue2;
        this.blue3 = -1;
        this.blue4 = -1;
        this.tPA = 2;
    }

    public MyMatch(SimpleMatch match) {
        this.matchNum = match.getMatchNumber();
        this.compLevel = match.getCompLevel();
        this.red1 = Integer.parseInt(match.getRedAlliance().getTeamKeys()[0].substring(3));
        this.red2 = Integer.parseInt(match.getRedAlliance().getTeamKeys()[1].substring(3));
        this.red3 = Integer.parseInt(match.getRedAlliance().getTeamKeys()[2].substring(3));
        this.blue1 = Integer.parseInt(match.getBlueAlliance().getTeamKeys()[0].substring(3));
        this.blue2 = Integer.parseInt(match.getBlueAlliance().getTeamKeys()[1].substring(3));
        this.blue3 = Integer.parseInt(match.getBlueAlliance().getTeamKeys()[2].substring(3));
        this.tPA = 3;
    }

    public int getRed1(int pos) {
        return this.red1;
    }

    public int getRed2(int pos) {
        return this.red2;
    }

    public int getRed3(int pos) {
        return this.red3;
    }

    public int getRed4(int pos) {
        return this.red4;
    }

    public int getBlue1(int pos) {
        return this.blue1;
    }

    public int getBlue2(int pos) {
        return this.blue2;
    }

    public int getBlue3(int pos) {
        return this.blue3;
    }

    public int getBlue4(int pos) {
        return this.blue4;
    }


    public void printMatch() {
        System.out.println("Match " + this.matchNum);
        System.out.println("Red 1 " + this.red1);
        System.out.println("Red 2 " + this.red2);
        System.out.println("Red 3 " + this.red3);
        System.out.println("Blue 1 " + this.blue1);
        System.out.println("Blue 2 " + this.blue2);
        System.out.println("Blue 3 " + this.blue3);
    }

    public String exportMatch() {
        String export = "";
        export+=matchNum+","+red1+","+red2+","+red3+","+blue1+","+blue2+","+blue3;
        return export;
    }

}
