﻿// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;

namespace IxMilia.Dxf.Generator
{
    public class Program
    {
        private const string EntityDirString = "--entityDir=";
        private const string ObjectDirString = "--objectDir=";
        private const string SectionDirString = "--sectionDir=";
        private const string TableDirString = "--tableDir=";

        public static void Main(string[] args)
        {
            string entityDir = "Entities";
            string objectDir = "Objects";
            string sectionDir = "Sections";
            string tableDir = "Tables";
            foreach (var arg in args)
            {
                if (arg.StartsWith(EntityDirString))
                {
                    entityDir = arg.Substring(EntityDirString.Length);
                }
                else if (arg.StartsWith(ObjectDirString))
                {
                    objectDir = arg.Substring(ObjectDirString.Length);
                }
                else if (arg.StartsWith(SectionDirString))
                {
                    sectionDir = arg.Substring(SectionDirString.Length);
                }
                else if (arg.StartsWith(TableDirString))
                {
                    tableDir = arg.Substring(TableDirString.Length);
                }
            }

            Console.WriteLine($"Generating entities into: {entityDir}");
            Console.WriteLine($"Generating objects into: {objectDir}");
            Console.WriteLine($"Generating sections into: {sectionDir}");
            Console.WriteLine($"Generating tables into: {tableDir}");
            new EntityGenerator(entityDir).Run();
            new ObjectGenerator(objectDir).Run();
            new SectionGenerator(sectionDir).Run();
            new TableGenerator(tableDir).Run();
        }
    }
}
