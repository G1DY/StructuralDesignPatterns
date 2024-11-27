using StructuralDesignPatterns.Adapter;
using StructuralDesignPatterns.Adapter.Package;

var videoEditor =  new VideoEditor(new Video());
videoEditor.ApplyColor(new RainbowColor(new RainbowInheritance()));