using System;

namespace _011_Flood_Fill
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * An image is represented by a 2-D array of integers, each integer representing the pixel value of the image (from 0 to 65535).
  
             * Given a coordinate (sr, sc) representing the starting pixel (row and column) of the flood fill, and a pixel value newColor, 
               "flood fill" the image.
  
             * To perform a "flood fill", consider the starting pixel, 
               plus any pixels connected 4-directionally to the starting pixel of the same color as the starting pixel, 
               plus any pixels connected 4-directionally to those pixels (also with the same color as the starting pixel), 
               and so on. Replace the color of all of the aforementioned pixels with the newColor.
  
             * At the end, return the modified image.
  
             * Example 1:
             * Input: 
             * image = [[1,1,1],[1,1,0],[1,0,1]]
             * sr = 1, sc = 1, newColor = 2
             * Output: [[2,2,2],[2,2,0],[2,0,1]]

             * Explanation: 
             * From the center of the image (with position (sr, sc) = (1, 1)), all pixels connected 
             * by a path of the same color as the starting pixel are colored with the new color.
             * Note the bottom corner is not colored 2, because it is not 4-directionally connected
             * to the starting pixel.

             * Note:
             * The length of image and image[0] will be in the range [1, 50].
             * The given starting pixel will satisfy 0 <= sr < image.length and 0 <= sc < image[0].length.
             * The value of each color in image[i][j] and newColor will be an integer in [0, 65535].
            */

            var image = new int[3][];
            image[0] = new int[] { 1, 1, 1 };
            image[1] = new int[] { 1, 1, 0 };
            image[2] = new int[] { 1, 0, 1 };

            var sr = 1;
            var sc = 1;
            var newColor = 2;
            var solution = new Solution();
            var result = solution.FloodFill(image, sr, sc, newColor);

            var exceptOutput = new int[3][];
            exceptOutput[0] = new int[] { 2, 2, 2 };
            exceptOutput[1] = new int[] { 2, 2, 0 };
            exceptOutput[2] = new int[] { 2, 0, 1 };

            var check = true;

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result[i].Length; j++)
                {
                    if (exceptOutput[i][j] != result[i][j])
                    {
                        check = false;
                    }
                }
            }

            Console.WriteLine(check);
        }
    }

    public class Solution
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            throw new NotImplementedException();
        }
    }
}
