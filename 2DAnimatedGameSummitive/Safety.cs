﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2DAnimatedGameSummitive
{
    internal class Safety
    {
        public int safetyX, safetyY, safetyWidth, safetyHeight;

        public Safety(int _safetyX, int _safetyY, int _safetyWidth, int _safetyHeight)
        {
            safetyX = _safetyX;
            safetyY = _safetyY;
            safetyWidth = _safetyWidth;
            safetyHeight = _safetyHeight;
        }

        public bool Collision(Safety s)
        {
            Rectangle safetyRec = new Rectangle(s.safetyX, s.safetyY, s.safetyWidth, s.safetyHeight);
            Rectangle safetyRec2 = new Rectangle(s.safetyX, s.safetyY, s.safetyWidth, s.safetyHeight);
            if (safetyRec.IntersectsWith(safetyRec2))
            {
                s.safetyX++;
                return true;
            }
            else if (safetyRec.IntersectsWith(safetyRec2))
            {
                s.safetyX--;
                return true;
            }
            return false;
        }
    }
}
