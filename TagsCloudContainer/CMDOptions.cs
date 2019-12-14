﻿using System;
using System.Collections.Generic;
using CommandLine;

namespace TagsCloudContainer
{
    public sealed class CMDOptions 
    {
        [Option('i', "input",
            Required = true,
            HelpText = "Input file with data with words.")]
        public string InputFile { get; set; }
        
        [Option('o', "output",
            Required = true,
            HelpText = "Output file name or path")]
        public string OutputFile { get; set; }

        [Option('w', "width",
            Required =  true,
            HelpText = "Input width size of bitmap/cloud.")]
        public int Width { get; set; }
        
        [Option('h', "height",
            Required =  true,
            HelpText = "Input height size of bitmap/cloud.")]
        public int Height { get; set; }
        
        [Option('c', "color",
            Required =  false,
            Default =  "Black",
            HelpText = "Color of text and border")]
        public string Color { get; set; }
        
        [Option('f', "font", 
            Required =  false,
            Default =  "Tahoma",
            HelpText = "Font name")]
        public string Font { get; set; }
    }
}