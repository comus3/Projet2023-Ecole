﻿namespace seance2;

public class Cote : Eval
{
    private int note;
    public Cote(int note,Activite activite): base(activite)
    {
        this.note = note;

    }
    public override int Note()
    {
        return note;
    }
    public void SetNote(int note)
    {
        this.note = note;
    }

}
