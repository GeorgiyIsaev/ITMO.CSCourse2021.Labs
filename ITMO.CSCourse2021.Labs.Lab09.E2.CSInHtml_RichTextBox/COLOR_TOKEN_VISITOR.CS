
namespace CSharp
{ 
    using System;
	using System.Windows.Forms;
	using System.Drawing;
    
    public sealed class ColorTokenVisitor : ITokenVisitor
    {
		public ColorTokenVisitor(RichTextBox rtb)
		{
			target = rtb;	
			target.Clear();
		}
		
        public void Visit(ILineStartToken line)
        {
			String number = String.Format("{0,3} ", line.Number());
			Write(number, Color.Gray);
        }
        
        public void Visit(ILineEndToken t)
        {
            Write("\n", Color.White);
        }

        public void Visit(ICommentToken token)
        {
            Write(token, Color.Green);
        }
        
        public void Visit(IIdentifierToken token)
        {
            Write(token, Color.Black);
        }
        
        public void Visit(IKeywordToken token)
        {
            Write(token, Color.Blue);            
        }

        public void Visit(IDirectiveToken token)
        {
            Write(token, Color.Gray);
        }
        
        public void Visit(IWhiteSpaceToken token)
        {
            Write(token, Color.White);
        }
        
        public void Visit(IOtherToken token)
        {
            Write(token, Color.Black);
        }
        
		private void Write(IToken token, Color color) 
		{
			Write(token.ToString(), color);	
		}
		
        private void Write(string token, Color color)
        {
			target.AppendText(token);
			target.Select(index, index + token.Length);
			index += token.Length;
			target.SelectionColor = color;
		}
        
		private RichTextBox target;
		private int index = 0;
	} 
} 
