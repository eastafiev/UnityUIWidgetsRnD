using System.Collections.Generic;
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
using Rect = UnityEngine.Rect;

namespace UIWidgetsSample
{
    public class MyConvertedWidget : UIWidgetsPanel
    {
        [SerializeField] public float m_radius = 20.0f;
        protected override Widget createWidget()
        {
            return new MaterialApp(
                home: new ClipRRect(
                    borderRadius: BorderRadius.circular(m_radius),
                    clipBehavior: Clip.antiAlias,
                    
                    child: new MyApp())
                    ); 
                
        }

    }

    public class MyApp : StatelessWidget
    {
        public override Widget build(BuildContext contex)
        {
            return new MaterialApp(
                
                title: "Generated App",
                
                // theme: new ThemeData(
                //     primarySwatch: Colors.brown,
                //     primaryColor: new Color(0xFF2196f3),
                //     accentColor: new Color(0xFF2196f3),
                //     canvasColor: new Color(0xFFfafafa)),
                // home:new ClipRRect( 
                //     borderRadius: BorderRadius.circular(20.0f),
                //     child: 
                    home:new MyHomePage());

        }
    }

    public class MyHomePage : StatefulWidget
    {
        public MyHomePage(Key key = null) : base(key: key){}


        public override State createState()
        {
            return new MyHomePageState();
        }
    }

    public class MyHomePageState : State<MyHomePage>
    {
        public override Widget build(BuildContext context)
        {
            List<Widget> tapChildren = new List<Widget>();
            tapChildren.Add(new Text("text"));
            tapChildren.Add(new Text("text2"));
           
            
            
            var scaffold =  new Scaffold(
                appBar: new AppBar(
                    title: new Text(data:"App Name")
                    
                    //shape: new SHAPE
                     //,
                      // bottom:
                      // new TabBar(
                          //controller: this._tabController,
                          //tabs: tapChildren)
                    //  new TabBar(tabs: new List<Widget>() {new Text("text"), new Text("text 2")}
                    // )

                ),
                body:
                new RaisedButton(
                    key: null,
                    onPressed: buttonPressed,
                    color: new Color(0xFFe0e0e0),
                    child: new Text(
                        data: "BUTTON 1", 
                        style: new TextStyle(
                            fontSize: 12.0f,
                            color: new Color(0xFF000000),
                            fontWeight: FontWeight.w200,
                            fontFamily: "Roboto")
                    )
                )

            );

            BoxDecoration myBoxDecoration()
            {
                return new BoxDecoration(
                    border: Border.all(
                        width: 2),
                        borderRadius: BorderRadius.all(
                        Radius.circular(25f))
                );
            }
            
            return new Container(
                //decoration: myBoxDecoration(),
                child: scaffold
                
            );

        }

        void buttonPressed()
        {
        }

    }
}