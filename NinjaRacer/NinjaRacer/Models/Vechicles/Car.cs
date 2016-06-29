﻿namespace NinjaRacer.Models.Vechicles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Infrastructure.Constants;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Input;

    internal class Car : MovingObject
    {
        public Car(Texture2D texture, Vector2 position, int speed)
            : base(texture, position, speed)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Texture, this.position);
        }

        public override void Update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Right) || Keyboard.GetState().IsKeyDown(Keys.D))
            {
                //move right
                if (this.position.X < Grafic.WindowWidth - this.Texture.Width - Grafic.BufferWidth)
                {
                    this.position.X += this.Speed;
                }
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left) || Keyboard.GetState().IsKeyDown(Keys.A))
            {
                ///move left
                if (this.position.X > Grafic.BufferWidth)
                {
                    this.position.X -= this.Speed;
                }
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Up) || Keyboard.GetState().IsKeyDown(Keys.W))
            {
                ///move up
                if (this.position.Y > Grafic.BuferHight)
                {
                    this.position.Y -= this.Speed;
                }
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down) || Keyboard.GetState().IsKeyDown(Keys.S))
            {
                ///move down
                if (this.position.Y < Grafic.WindowHight - this.Texture.Height)
                {
                    this.position.Y += this.Speed;
                }
            }
        }
        public int GetCarSize()
        {
            return this.Texture.Width;
        }
    }
}
