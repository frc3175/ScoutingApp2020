package com.frc3175.scoutcompanionapp;

import com.thebluealliance.api.v3.models.SimpleMatch;

public class MyMatch {
    public int matchNum;
    private int red1;
    private int red2;
    private int red3;
    private int blue1;
    private int blue2;
    private int blue3;
    public String compLevel;



    public MyMatch(SimpleMatch match) {
        this.matchNum = match.getMatchNumber();
        this.compLevel = match.getCompLevel();
        this.red1 = Integer.parseInt(match.getRedAlliance().getTeamKeys()[0].substring(3));
        this.red2 = Integer.parseInt(match.getRedAlliance().getTeamKeys()[1].substring(3));
        this.red3 = Integer.parseInt(match.getRedAlliance().getTeamKeys()[2].substring(3));
        this.blue1 = Integer.parseInt(match.getBlueAlliance().getTeamKeys()[0].substring(3));
        this.blue2 = Integer.parseInt(match.getBlueAlliance().getTeamKeys()[1].substring(3));
        this.blue3 = Integer.parseInt(match.getBlueAlliance().getTeamKeys()[2].substring(3));
    }
    public String exportMatch() {
        String export = "";
        export+=matchNum+","+red1+","+red2+","+red3+","+blue1+","+blue2+","+blue3;
        return export;
    }

}
