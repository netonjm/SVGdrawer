using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace SVGdrawer.Windows
{
    class Map
    {

        public List<Layer> Layers;
        public Vector2 TileDimensions;


        public void Initialize(ContentManager content)
        {
            foreach (Layer l in Layers)
            {
                l.Initialize(content, TileDimensions);
            }
        }



        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Layer i in Layers)
            {
                i.Draw(spriteBatch);
            }

        }


    }



}
