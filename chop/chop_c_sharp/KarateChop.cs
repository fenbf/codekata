using System;

namespace chop_c_sharp
{
    public static class KarateChop
    {
        #region chop, loop version
        /// <summary>
        /// binary search, loop version
        /// </summary>
        /// <param name="target">value to search</param>
        /// <param name="values">array with values</param>
        /// <returns>position of the found element, or -1 when not found or error</returns>
        /// at the beginning I needed some time to figure out how binary search actually works :)
        /// But after some time it was quite easy to write that simple code.
        public static int chop(int target, int[] values)
        {
            if (values == null)
                return -1;
            
            int left = 0;
            int right = values.Length - 1;

            while (left <= right)
            {
                int center = (left + right)/2;

                if (target == values[center])
                    return center;

                if (target < values[center])
                {
                    right = center - 1;
                }
                else
                {
                    left = center + 1;
                }
            }

            return -1;
        }
        #endregion

        #region chop, recursive version
        /// <summary>
        /// binary search, recursive version
        /// </summary>
        /// <param name="target">value to search</param>
        /// <param name="values">array with values</param>
        /// <returns>position of the found element, or -1 when not found or error</returns>
        /// At first I had problems with the proper naming, I choose "chop2"... but it will change probably.
        public static int chop2(int target, int[] values)
        {
            if (values == null || values.Length == 0) 
                return -1;

            return chopRecursive(target, values, 0, values.Length-1);
        }

        private static int chopRecursive(int target, int[] values, int left, int right)
        {
            if (left > right)
                return -1;

            int center = (left + right) / 2;

            if (target == values[center])
                return center;

            if (target < values[center])
                return chopRecursive(target, values, left, center-1);
            
            return chopRecursive(target, values, center+1, right);
        }
        #endregion

        #region chop, array slicing

        /// <summary>
        /// binary search, array slicing version
        /// </summary>
        /// <param name="target">value to search</param>
        /// <param name="values">array with values</param>
        /// <returns>position of the found element, or -1 when not found or error</returns>
        /// Array slicing seems to be too cumbersome, exaggerated
        public static int chopSlice(int target, int[] values)
        {
            if (values == null)
                return -1;

            return chopSliceSegment(target, new ArraySegment<int>(values));
        }

        private static int chopSliceSegment(int target, ArraySegment<int> valueSegment)
        {
            if (valueSegment.Count == 0) 
                return -1;

            int left = valueSegment.Offset;
            int right = valueSegment.Offset + valueSegment.Count - 1;
            int center = (left + right) / 2;
            
            if (target == valueSegment.Array[center])
                return center;

            if (target < valueSegment.Array[center])
                return chopSliceSegment(target, new ArraySegment<int>(valueSegment.Array, left, center - left));
                
            return chopSliceSegment(target, new ArraySegment<int>(valueSegment.Array, center + 1, right - center));
        }
        #endregion

        #region chop, array slicing 2

        /// <summary>
        /// binary search, array slicing version
        /// </summary>
        /// <param name="target">value to search</param>
        /// <param name="values">array with values</param>
        /// <returns>position of the found element, or -1 when not found or error</returns>
        /// Array slicing, but with doing a copy
        public static int chopSlice2(int target, int[] values)
        {
            if (values == null || values.Length == 0)
                return -1;

            int left = 0;
            int right = values.Length - 1;
            int center = (left + right) / 2;

            if (target == values[center])
                return center;

            if (target < values[center])
                return chopSlice2(target, SubArray(values, 0, center-1));

            int ret = chopSlice2(target, SubArray(values, center+1, right));
            return ret == -1 ? ret : center + 1 + ret;
        }

        private static T[] SubArray<T>(T[] data, int left, int right)
        {
            T[] result = new T[right - left + 1];
            Array.Copy(data, left, result, 0, result.Length);
            return result;
        }

        #endregion

        #region chop, generics, using loop version
        /// <summary>
        /// binary search, loop version, using generics
        /// </summary>
        /// <param name="target">value to search</param>
        /// <param name="values">array with values</param>
        /// <returns>position of the found element, or -1 when not found or error</returns>
        /// Fifth version of the solution, I used simple idea - add generics, but maybe there is
        /// some better and more interesting way of doing it?
        public static int chopGeneric<T>(T target, T[] values) where T : System.IComparable<T>
        {
            if (values == null)
                return -1;

            int left = 0;
            int right = values.Length - 1;

            while (left <= right)
            {
                int center = (left + right) / 2;
                int cmp = target.CompareTo(values[center]);

                if (cmp == 0) return center;
                else if (cmp < 0) right = center - 1;
                else left = center + 1;
            }

            return -1;
        }
        #endregion
    }
}
