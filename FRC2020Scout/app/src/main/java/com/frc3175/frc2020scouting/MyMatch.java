package com.frc3175.frc2020scouting;

public class MyMatch {
    public String matchNum;
    private String red1;
    private String red2;
    private String red3;
    private String blue1;
    private String blue2;
    private String blue3;
    public String[] teams;



    public MyMatch(String[] matchData) {
        this.teams = new String[6];
        this.matchNum = matchData[0];
        this.teams[0] = matchData[1];
        this.red1 = matchData[1];
        this.teams[1] = matchData[2];
        this.red2 = matchData[2];
        this.teams[2] = matchData[3];
        this.red3 = matchData[3];
        this.teams[3] = matchData[4];
        this.blue1 = matchData[4];
        this.teams[4] = matchData[5];
        this.blue2 = matchData[5];
        this.teams[5] = matchData[6];
        this.blue3 = matchData[6];
    }
    public String exportMatch() {
        String export = "";
        export+=matchNum+","+red1+","+red2+","+red3+","+blue1+","+blue2+","+blue3;
        return export;
    }






}
