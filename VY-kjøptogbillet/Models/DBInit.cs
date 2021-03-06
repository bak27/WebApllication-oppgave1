﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using static VY_kjøptogbillet.Models.DBModel;

namespace VY_kjøptogbillet.Models
{
    public class DBInit : DropCreateDatabaseAlways<DB>

    {
        protected override void Seed(DB context)
        {
            var nystrekning1 = new Strekning
            {
             Fra="Oslo",
             Til="Bergen"
            };
            var nystrekning2 = new Strekning
            {
                Fra = "Oslo",
                Til = "Stavanger"
            };
            var nystrekning3 = new Strekning
            {
                Fra = "Oslo",
                Til = "Krstiansand"
            };


            var nystrekning4 = new Strekning
            {
                Fra = "Oslo",
                Til = "Trondiheim"
            };
            var nystrekning5 = new Strekning
            {
                Fra = "Oslo",
                Til = "Drammen"
            };
            var nystrekning6 = new Strekning
            {
                Fra = "Oslo",
                Til = "OsloLufthaven"
            };

            var nystrekning7 = new Strekning
            {
                Fra = "Oslo",
                Til = "Lillehammer"
            };
            var nystrekning8 = new Strekning
            {
                Fra = "Oslo",
                Til = "Skien"
            };

            var nystrekning9 = new Strekning
            {
                Fra = "Oslo",
                Til = "Gjøvik"
            };

            var nystrekning10 = new Strekning
            {
                Fra = "Bergen",
                Til = "Oslo"
            };

            var nystrekning11 = new Strekning
            {
                Fra = "Bergen",
                Til = "Drammen"
            };


            var nystrekning12 = new Strekning
            {
                Fra = "Stavanger",
                Til = "Oslo"
            };

            var nystrekning13 = new Strekning
            {
                Fra = "Stavanger",
                Til = "KrstianSand"
            };


            var nystrekning14 = new Strekning
            {
                Fra = "Stavanger",
                Til = "Drammen"
            };


            var nystrekning15 = new Strekning
            {
                Fra = "KrstianSand",
                Til = "Oslo"
            };

            var nystrekning16 = new Strekning
            {
                Fra = "KrstianSand",
                Til = "Drammen"
            };
            var nystrekning17 = new Strekning
            {
                Fra = "KrstianSand",
                Til = "Stavanger"
            };


            var nystrekning18 = new Strekning
            {
                Fra = "Trondiheim",
                Til = "Oslo"
            };

            var nystrekning19 = new Strekning
            {
                Fra = "Trondiheim",
                Til = "Lillehammer"
            };

            var nystrekning20 = new Strekning
            {
                Fra = "Trondiheim",
                Til = "Drammen"
            };

            var nystrekning21 = new Strekning
            {
                Fra = "Drammen",
                Til = "Oslo"
            };

            var nystrekning22 = new Strekning
            {
                Fra = "Drammen",
                Til = "Krstiansand"
            };

            var nystrekning23 = new Strekning
            {
                Fra = "Drammen",
                Til = "Stavanger"
            };

            var nystrekning24 = new Strekning
            {
                Fra = "Drammen",
                Til = "Bergen"
            };

            var nystrekning25 = new Strekning
            {
                Fra = "Drammen",
                Til = "OsloLufthaven"
            };

            var nystrekning26 = new Strekning
            {
                Fra = "OsloLufthaven",
                Til = "Oslo"
            };

            var nystrekning27 = new Strekning
            {
                Fra = "Skien",
                Til = "Oslo"
            };

            var nystrekning28 = new Strekning
            {
                Fra = "Gjøvik",
                Til = "Oslo"
            };
            var nystrekning29 = new Strekning
            {
                Fra = "Lillehammer",
                Til = "Oslo"
            };

            var nystrekning30 = new Strekning
            {
                Fra = "Lillehammer",
                Til = "OsloLufthaven"
            };




            var nyavgang1 = new Avgang
            {
               
                FraogTiltid= "10:30-17:30",
                Lengdne="7timer",
                Price=599,
                Strekning =nystrekning1
                
            };
            var nyavgang2 = new Avgang
            {

                FraogTiltid = "14:30-21:30",
                Lengdne ="7timer",
                Price=499,
                Strekning = nystrekning1

            };
            var nyavgang3 = new Avgang
            {

                FraogTiltid = "08:30-16:30",
                Lengdne ="8timer",
                Price=499,
                Strekning = nystrekning2
            };

            var nyavgang4 = new Avgang
            {


                FraogTiltid = "10:30-17:30",
                Lengdne ="7timer",
                Price=599,
                Strekning = nystrekning2

            };
            var nyavgang5 = new Avgang
            {

                FraogTiltid = "10:30-15:30",
                Lengdne ="5timer",
                Price=299,
                Strekning = nystrekning3

            };

            var nyavgang6 = new Avgang
            {

                FraogTiltid = "15:30-21:00",
                Lengdne ="5.5timer",
                Price=599,
                Strekning = nystrekning3

            };


            var nyavgang7 = new Avgang
            {

                FraogTiltid = "10:30-17:30",
                Lengdne ="6.5timer",
                Price=449,
                Strekning = nystrekning4

            };

            var nyavgang8 = new Avgang
            {

                FraogTiltid = "14:30-20:30",
                Lengdne = "6timer",
                Price = 499,
                Strekning = nystrekning4

            };

            var nyavgang9 = new Avgang
            {

                FraogTiltid = "08:30-09:20",
                Lengdne = "50min",
                Price = 90,
                Strekning = nystrekning5

            };


            var nyavgang10 = new Avgang
            {

                FraogTiltid = "10:30-11:20",
                Lengdne = "50min",
                Price = 90,
                Strekning = nystrekning5

            };

            var nyavgang11 = new Avgang
            {

                FraogTiltid = "12:30-13:20",
                Lengdne = "50min",
                Price = 90,
                Strekning = nystrekning5

            };

            var nyavgang12 = new Avgang
            {

                FraogTiltid = "18:30-19:20",
                Lengdne = "50min",
                Price = 90,
                Strekning = nystrekning5

            };

            var nyavgang13 = new Avgang
            {

                FraogTiltid = "07:30-07:56",
                Lengdne = "25min",
                Price = 90,
                Strekning = nystrekning6
            };
            var nyavgang14 = new Avgang
            {

                FraogTiltid = "08:30-08:55",
                Lengdne = "25min",
                Price = 90,
                Strekning = nystrekning6

            };
            var nyavgang15 = new Avgang
            {

                FraogTiltid = "14:30-14:55",
                Lengdne = "25min",
                Price = 90,
                Strekning = nystrekning6

            };
            var nyavgang16 = new Avgang
            {

                FraogTiltid = "18:30-18:55",
                Lengdne = "25min",
                Price = 90,
                Strekning = nystrekning6

            };


            var nyavgang17 = new Avgang
            {

                FraogTiltid = "08:30-11:00",
                Lengdne = "2.5timer",
                Price = 299,
                Strekning = nystrekning7

            };
            var nyavgang18 = new Avgang
            {

                FraogTiltid = "12:30-15:00",
                Lengdne = "2.5timer",
                Price = 299,
                Strekning = nystrekning7

            };


            var nyavgang19 = new Avgang
            {

                FraogTiltid = "10:30-13:00",
                Lengdne = "2.5timer",
                Price = 299,
                Strekning = nystrekning8

            };


            var nyavgang20 = new Avgang
            {

                FraogTiltid = "16:30-19:00",
                Lengdne = "2.5timer",
                Price = 299,
                Strekning = nystrekning8

            };


            var nyavgang21 = new Avgang
            {

                FraogTiltid = "10:30-12:30",
                Lengdne = "2timer",
                Price = 299,
                Strekning = nystrekning9

            };
            var nyavgang22 = new Avgang
            {

                FraogTiltid = "18:30-20:30",
                Lengdne = "2timer",
                Price = 299,
                Strekning = nystrekning9

            };


            var nyavgang23 = new Avgang
            {

                FraogTiltid = "08:30-16:30",
                Lengdne = "8timer",
                Price = 599,
                Strekning = nystrekning10

            };

            var nyavgang24 = new Avgang
            {

                FraogTiltid = "18:30-00:30",
                Lengdne = "6tmer",
                Price = 599,
                Strekning = nystrekning10

            };
            var nyavgang25 = new Avgang
            {

                FraogTiltid = "08:30-15:30",
                Lengdne = "7timer",
                Price = 549,
                Strekning = nystrekning11

            };

            var nyavgang26 = new Avgang
            {

                FraogTiltid = "18:30-23:30",
                Lengdne = "5timer",
                Price = 549,
                Strekning = nystrekning11

            };

            var nyavgang27 = new Avgang
            {

                FraogTiltid = "08:30-17:30",
                Lengdne = "8timer",
                Price = 599,
                Strekning = nystrekning12

            };

            var nyavgang28= new Avgang
            {

                FraogTiltid = "08:30-11:30",
                Lengdne = "3timer",
                Price = 299,
                Strekning = nystrekning13

            };


            var nyavgang29 = new Avgang
            {

                FraogTiltid = "18:30-00:30",
                Lengdne = "6timer",
                Price = 499,
                Strekning = nystrekning12

            };


            var nyavgang30 = new Avgang
            {

                FraogTiltid = "18:30-21:30",
                Lengdne = "3timer",
                Price = 299,
                Strekning = nystrekning13

            };


            var nyavgang31 = new Avgang
            {

                FraogTiltid = "08:30-15:30",
                Lengdne = "5timer",
                Price = 399,
                Strekning = nystrekning14

            };


            var nyavgang32 = new Avgang
            {

                FraogTiltid = "11:30-16:30",
                Lengdne = "5timer",
                Price = 499,
                Strekning = nystrekning15

            };


            var nyavgang33 = new Avgang
            {

                FraogTiltid = "21:30-00:30",
                Lengdne = "3timer",
                Price = 399,
                Strekning = nystrekning15

            };


            var nyavgang34 = new Avgang
            {

                FraogTiltid = "11:30-15:30",
                Lengdne = "4timer",
                Price = 399,
                Strekning = nystrekning16

            };


            var nyavgang35= new Avgang
            {

                FraogTiltid = "13:30-16:30",
                Lengdne = "3timer",
                Price = 299,
                Strekning = nystrekning17

            };

            var nyavgang36 = new Avgang
            {

                FraogTiltid = "10:30-16:30",
                Lengdne = "6timer",
                Price = 399,
                Strekning = nystrekning18

            };

            var nyavgang37 = new Avgang
            {

                FraogTiltid = "15:30-21:30",
                Lengdne = "6timer",
                Price = 399,
                Strekning = nystrekning18

            };

            var nyavgang38 = new Avgang
            {

                FraogTiltid = "18:30-00:30",
                Lengdne = "6timer",
                Price = 299,
                Strekning = nystrekning12

            };
            var nyavgang39 = new Avgang
            {

                FraogTiltid = "10:30-13:30",
                Lengdne = "3timer",
                Price = 299,
                Strekning = nystrekning19

            };

            var nyavgang40 = new Avgang
            {

                FraogTiltid = "10:30-12:30",
                Lengdne = "5timer",
                Price = 299,
                Strekning = nystrekning20

            };

            var nyavgang41 = new Avgang
            {

                FraogTiltid = "08:30-09:20",
                Lengdne = "50min",
                Price = 90,
                Strekning = nystrekning21

            };

            var nyavgang42 = new Avgang
            {

                FraogTiltid = "10:30-11:20",
                Lengdne = "50min",
                Price = 90,
                Strekning = nystrekning21

            };


            var nyavgang43 = new Avgang
            {

                FraogTiltid = "12:30-13:20",
                Lengdne = "50min",
                Price = 90,
                Strekning = nystrekning21

            };


            var nyavgang44 = new Avgang
            {

                FraogTiltid = "16:30-17:20",
                Lengdne = "50min",
                Price = 90,
                Strekning = nystrekning21

            };

            var nyavgang45 = new Avgang
            {

                FraogTiltid = "19:30-20:20",
                Lengdne = "50min",
                Price = 90,
                Strekning = nystrekning21

            };

            var nyavgang46 = new Avgang
            {

                FraogTiltid = "09:30-14:30",
                Lengdne = "5timer",
                Price = 499,
                Strekning = nystrekning22

            };



            var nyavgang47 = new Avgang
            {

                FraogTiltid = "17:30-22:30",
                Lengdne = "5timer",
                Price = 499,
                Strekning = nystrekning22

            };

            var nyavgang48 = new Avgang
            {

                FraogTiltid = "09:30-16:30",
                Lengdne = "7timer",
                Price = 499,
                Strekning = nystrekning23

            };

            var nyavgang49= new Avgang
            {

                FraogTiltid = "17:30-23:30",
                Lengdne = "6timer",
                Price = 499,
                Strekning = nystrekning23

            };

            var nyavgang50 = new Avgang
            {

                FraogTiltid = "09:30-15:30",
                Lengdne = "6timer",
                Price = 499,
                Strekning = nystrekning24

            };

            var nyavgang51 = new Avgang
            {

                FraogTiltid = "10:30-10:55",
                Lengdne = "25min",
                Price = 103,
                Strekning = nystrekning26

            };


            var nyavgang52 = new Avgang
            {

                FraogTiltid = "12:30-12:55",
                Lengdne = "25min",
                Price = 103,
                Strekning = nystrekning26

            };
            var nyavgang53 = new Avgang
            {

                FraogTiltid = "14:30-14:55",
                Lengdne = "25min",
                Price = 103,
                Strekning = nystrekning26

            };
            var nyavgang54 = new Avgang
            {

                FraogTiltid = "16:30-16:55",
                Lengdne = "25min",
                Price = 103,
                Strekning = nystrekning26

            };
            var nyavgang55 = new Avgang
            {

                FraogTiltid = "18:30-18:55",
                Lengdne = "25min",
                Price = 103,
                Strekning = nystrekning26

            };



            var nyavgang56 = new Avgang
            {

                FraogTiltid = "10:30-13:00",
                Lengdne = "2.5timer",
                Price = 299,
                Strekning = nystrekning27

            };
            var nyavgang57 = new Avgang
            {

                FraogTiltid = "15:30-18:00",
                Lengdne = "2.5timer",
                Price = 299,
                Strekning = nystrekning27

            };
            var nyavgang58 = new Avgang
            {

                FraogTiltid = "10:30-10:55",
                Lengdne = "2.5timer",
                Price = 299,
                Strekning = nystrekning28

            };

            var nyavgang59 = new Avgang
            {

                FraogTiltid = "14:30-17:00",
                Lengdne = "2.5timer",
                Price = 299,
                Strekning = nystrekning28

            };

            var nyavgang60 = new Avgang
            {

                FraogTiltid = "10:30-13:30",
                Lengdne = "3timer",
                Price = 299,
                Strekning = nystrekning29

            };


            var nyavgang61 = new Avgang
            {

                FraogTiltid = "15:30-18:30",
                Lengdne = "3timer",
                Price = 299,
                Strekning = nystrekning29

            };

            var nyavgang62 = new Avgang
            {

                FraogTiltid = "10:30-11:30",
                Lengdne = "1timer",
                Price = 199,
                Strekning = nystrekning25

            };

            var nyavgang63 = new Avgang
            {

                FraogTiltid = "13:30-14:30",
                Lengdne = "1timer",
                Price = 199,
                Strekning = nystrekning25

            };


            var nyavgang64 = new Avgang
            {

                FraogTiltid = "16:30-17:30",
                Lengdne = "1timer",
                Price = 199,
                Strekning = nystrekning25

            };




            var nyavgang65 = new Avgang
            {

                FraogTiltid = "10:30-13:00",
                Lengdne = "2.5timer",
                Price = 299,
                Strekning = nystrekning30

            };

            var nyavgang66 = new Avgang
            {

                FraogTiltid = "15:30-18:00",
                Lengdne = "2.5timer",
                Price = 199,
                Strekning = nystrekning25

            };


            var nystasjon1 = new Togstasjon
            {
                Stasjon = "Oslo"
            };

            var nystasjon2 = new Togstasjon
            {
                Stasjon = "Bergen"
            };

            var nystasjon3 = new Togstasjon
            {
                Stasjon = "Stavanger"
            };

            var nystasjon4 = new Togstasjon
            {
                Stasjon = "Krstiansand"
            };

            var nystasjon5 = new Togstasjon
            {
                Stasjon = "Trondiheim"
            };


            var nystasjon6 = new Togstasjon
            {
                Stasjon = "Drammen"
            };

            var nystasjon7 = new Togstasjon
            {
                Stasjon = "OsloLufthaven"
            };


            var nystasjon8 = new Togstasjon
            {
                Stasjon = "Lillehammer"
            };


            var nystasjon9 = new Togstasjon
            {
                Stasjon = "Skien"
            };

            var nystasjon10 = new Togstasjon
            {
                Stasjon = "Gjøvik"
            };
            var nyavganger = new List<Avgang>();
            nyavganger.Add(nyavgang1);
            nyavganger.Add(nyavgang2);
            nyavganger.Add(nyavgang3);
            nyavganger.Add(nyavgang4);
            nyavganger.Add(nyavgang5);
            nyavganger.Add(nyavgang6);
            nyavganger.Add(nyavgang7);
            nyavganger.Add(nyavgang8);
            nyavganger.Add(nyavgang9);
            nyavganger.Add(nyavgang10);
            nyavganger.Add(nyavgang11);
            nyavganger.Add(nyavgang12);
            nyavganger.Add(nyavgang13);
            nyavganger.Add(nyavgang14);
            nyavganger.Add(nyavgang15);
            nyavganger.Add(nyavgang16);
            nyavganger.Add(nyavgang17);
            nyavganger.Add(nyavgang18);
            nyavganger.Add(nyavgang19);
            nyavganger.Add(nyavgang20);
            nyavganger.Add(nyavgang21);
            nyavganger.Add(nyavgang22);
            nyavganger.Add(nyavgang23);
            nyavganger.Add(nyavgang24);
            nyavganger.Add(nyavgang25);
            nyavganger.Add(nyavgang26);
            nyavganger.Add(nyavgang27);
            nyavganger.Add(nyavgang28);
            nyavganger.Add(nyavgang29);
            nyavganger.Add(nyavgang30);
            nyavganger.Add(nyavgang31);
            nyavganger.Add(nyavgang32);
            nyavganger.Add(nyavgang33);
            nyavganger.Add(nyavgang34);
            nyavganger.Add(nyavgang35);
            nyavganger.Add(nyavgang34);
            nyavganger.Add(nyavgang37);
            nyavganger.Add(nyavgang38);
            nyavganger.Add(nyavgang39);
            nyavganger.Add(nyavgang40);
            nyavganger.Add(nyavgang41);
            nyavganger.Add(nyavgang42);
            nyavganger.Add(nyavgang43);
            nyavganger.Add(nyavgang44);
            nyavganger.Add(nyavgang45);
            nyavganger.Add(nyavgang46);
            nyavganger.Add(nyavgang47);
            nyavganger.Add(nyavgang48);
            nyavganger.Add(nyavgang49);
            nyavganger.Add(nyavgang50);
            nyavganger.Add(nyavgang51);
            nyavganger.Add(nyavgang52);
            nyavganger.Add(nyavgang53);
            nyavganger.Add(nyavgang54);
            nyavganger.Add(nyavgang55);
            nyavganger.Add(nyavgang56);
            nyavganger.Add(nyavgang57);
            nyavganger.Add(nyavgang58);
            nyavganger.Add(nyavgang59);
            nyavganger.Add(nyavgang60);
            nyavganger.Add(nyavgang61);
            nyavganger.Add(nyavgang62);
            nyavganger.Add(nyavgang63);
            nyavganger.Add(nyavgang64);
            nyavganger.Add(nyavgang65);
            nyavganger.Add(nyavgang66);

            var nystrekning = new List<Strekning>();
            nystrekning.Add(nystrekning1);
            nystrekning.Add(nystrekning2);
            nystrekning.Add(nystrekning3);
            nystrekning.Add(nystrekning4);
            nystrekning.Add(nystrekning5);
            nystrekning.Add(nystrekning6);
            nystrekning.Add(nystrekning7);
            nystrekning.Add(nystrekning8);
            nystrekning.Add(nystrekning9);
            nystrekning.Add(nystrekning10);
            nystrekning.Add(nystrekning11);
            nystrekning.Add(nystrekning12);
            nystrekning.Add(nystrekning13);
            nystrekning.Add(nystrekning14);
            nystrekning.Add(nystrekning15);
            nystrekning.Add(nystrekning16);
            nystrekning.Add(nystrekning17);
            nystrekning.Add(nystrekning18);
            nystrekning.Add(nystrekning19);
            nystrekning.Add(nystrekning20);
            nystrekning.Add(nystrekning21);
            nystrekning.Add(nystrekning22);
            nystrekning.Add(nystrekning23);
            nystrekning.Add(nystrekning24);
            nystrekning.Add(nystrekning25);
            nystrekning.Add(nystrekning26);
            nystrekning.Add(nystrekning27);
            nystrekning.Add(nystrekning28);
            nystrekning.Add(nystrekning29);
            nystrekning.Add(nystrekning30);

           var nystasjon = new List<Togstasjon>();
            nystasjon.Add(nystasjon1);
            nystasjon.Add(nystasjon2);
            nystasjon.Add(nystasjon3);
            nystasjon.Add(nystasjon4);
            nystasjon.Add(nystasjon5);
            nystasjon.Add(nystasjon6);
            nystasjon.Add(nystasjon7);
            nystasjon.Add(nystasjon8);
            nystasjon.Add(nystasjon9);
            nystasjon.Add(nystasjon10);


            context.Avganger.AddRange(nyavganger);
            context.Strekninger.AddRange(nystrekning);
            context.Togstasjoner.AddRange(nystasjon);
            base.Seed(context);
            }
    }
}