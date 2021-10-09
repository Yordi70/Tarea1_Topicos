using System;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;


namespace Tarea1_grafica
{
    class Game : GameWindow
    {
       
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title){}

        protected override void OnUpdateFrame(FrameEventArgs e)
        {

            base.OnUpdateFrame(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);

            base.OnLoad(e);
        }


        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            ///TRIANGULO
            GL.Begin(PrimitiveType.Triangles);
            GL.Color3(1.0f, 0.60f, 0.60f);
            GL.Vertex2(0.0, 0.4);
            GL.Vertex2(0.2, 0.0);
            GL.Vertex2(-0.2, 0.0);
            GL.End();
            ////
            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            base.OnResize(e);
        }
    }
}
