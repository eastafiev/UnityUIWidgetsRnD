using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.UIWidgets.animation;
using Unity.UIWidgets.engine;
using Unity.UIWidgets.foundation;
using Unity.UIWidgets.material;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;
using UnityEngine;
using Color = Unity.UIWidgets.ui.Color;
using FontStyle = Unity.UIWidgets.ui.FontStyle;
using Image = Unity.UIWidgets.ui.Image;
using Rect = UnityEngine.Rect;

public class MyConvertedWidgetTwo : UIWidgetsPanel
{
    [SerializeField] public float m_radius = 20.0f;

    protected override Widget createWidget()
    {
        return new MaterialApp(
            home: new ClipRRect(
                borderRadius: BorderRadius.circular(m_radius),
                child: new MyHomePageTwo())
        );
    }
}


public class MyHomePageTwo : StatefulWidget
{
    public MyHomePageTwo(Key key = null) : base(key: key)
    {
    }

    public override State createState()
    {
        return new MyHomePageStateTwo();
    }
}

public class MyHomePageStateTwo : State<MyHomePageTwo>
{
    public override Widget build(BuildContext context)
    {
        return new Scaffold(
            appBar: new AppBar(
                title: new Text("Test2")
            ),
            body: new ListView(
                children: new List<Widget>()
                {
                    Unity.UIWidgets.widgets.Image.asset("products/backpack",
                        width: 600,
                        height: 240,
                        fit: BoxFit.cover),
                    titleSection,
                    buttonSection,
                    textSection
                }
            ) ,
            bottomNavigationBar: new BottomNavigationBar(
            )
        );
    }

    // private Widget bottomBar = new BottomNavigationBar(
    //     items: new List<BottomNavigationBarItem>(
    //         new BottomNavigationBarItem(
    //             icon: new Icon(Icons.home)
    //
    //             // ,title: new Text("Home"),
    //             // backgroundColor: Colors.red
    //         )
    //
    //     )
    //     //currentIndex: 1,
    //     //selectedItemColor: Colors.amber[800]
    //     //,onTap: _onItemTapped
    //
    // );
    //
    
    
    
    // TitleSection
    private Widget titleSection = new Container(
        padding: EdgeInsets.all(32),
        color: Colors.white,
        child: new Row(
            children: new List<Widget>()
            {
                new Expanded(
                    child: new Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: new List<Widget>()
                        {
                            new Container(
                                padding: EdgeInsets.only(bottom: 8f),
                                child: new Text(
                                    "Eugene Astafiev",
                                    style: new TextStyle(
                                        fontWeight: FontWeight.bold
                                    )
                                )
                            ),
                            new Text(
                                data: "Lviv, Ukraine",
                                style: new TextStyle(
                                    color: Colors.grey[500]
                                )
                            )
                        }
                    )
                ),
                new Icon(Icons.star_border, color: Colors.red[500]),
                new Text("41")
            }
        )
    );

    // Button row
    private static Column _buildButtonColumn(Color color, IconData icon, String label)
    {
        return new Column(
            mainAxisSize: MainAxisSize.min,
            mainAxisAlignment: MainAxisAlignment.center,
            children: new List<Widget>()
            {
                new Icon(icon, color: color),
                new Container(
                    margin: EdgeInsets.only(top: 28),
                    child: new Text(
                        label,
                        style: new TextStyle(
                            fontSize: 12,
                            fontWeight: FontWeight.w400,
                            color: color
                        )
                    )
                )
            }
        );
    }

    private static Color color = Colors.green;

    private Widget buttonSection = new Container(
        child: new Row(
            mainAxisAlignment: MainAxisAlignment.spaceEvenly,
            children: new List<Widget>()
            {
                _buildButtonColumn(color, Icons.call, "CALL"),
                _buildButtonColumn(color, Icons.near_me, "ROUTE"),
                _buildButtonColumn(color, Icons.share, "SHARE"),
            }
        )
    );

    // TextSection
    Widget textSection = new Container(
        padding: EdgeInsets.all(32),
        child: new Text(
            "Lake Oeschinen lies at the foot of the Blüemlisalp in the Bernese " +
            "Alps. Situated 1,578 meters above sea level, it is one of the " +
            "larger Alpine Lakes. A gondola ride from Kandersteg, followed by a " +
            "half-hour walk through pastures and pine forest, leads you to the " +
            "lake, which warms to 20 degrees Celsius in the summer. Activities " +
            "enjoyed here include rowing, and riding the summer toboggan run.",
            softWrap: true
        )
    );
}