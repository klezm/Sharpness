using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sharpness
{
    // TODO
//    .transform
    //.anchorPoint
//UIApplication.sharedApplication()
//.setStatusBarHidden
//UIStatusBarAnimationFade
//.translationInView
//UIGestureRecognizerStateBegan
//.velocityInView
//dequeueReusableCellWithIdentifier
//UIColor.clearColor();
//UIView.alloc().init();
//.selectedBackgroundView
//.highlightedTextColor
    // id - NSObject
    // SEL - ObjCRuntime.Selector
    //    [[UIImageView alloc] initWithFrame:
    //imageView.image
    //UIViewContentModeCenter
    //NSTextAlignmentCenter
    //closing ]
    //.opacity
    //[[UIScreen mainScreen] scale]
    //CGImageRef imageRef = CGImageCreateWithImageInRect([image CGImage], scaledRect);
    //UIImageOrientationUp
    //CGImageRelease(imageRef);
    //font pointSize
    // [aView isKindOfClass:self] -> aView is this.GetType()
    //.image
    //UIScreen.mainScreen().Bounds().size;
    //CGContextTranslateCTM(context, window.Center().X, window.Center().Y);
    //CGContextConcatCTM(context, window.transform());
    //CGContextClearRect(context, new RectangleF(0, 0, window.Bounds().Width, 20));
    
    class Program
    {
        static void Main(string[] args)
        {
            //http://www.ishani.org/web/articles/code/clang-win32/

            /// <summary> input your desired file and output path (params: inputFile, outputPath, null ) </summary>
            //new SharpnessParser().TransformFile(InOut.sourceFolder, InOut.outFolder, null);

            /// <summary> does basically the same as above but doesnt process the header files for example </summary>
            //new SharpnessParser().ParseFile( InOut.sourceFolder, InOut.outFolder);

            Console.WriteLine("input your path withour quotes:");
            new InOut().PrintFiles();

}
    }
}
