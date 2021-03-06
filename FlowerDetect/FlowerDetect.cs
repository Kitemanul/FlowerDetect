//
// File generated by HDevelop for HALCON/.NET (C#) Version 17.12
//
//  This file is intended to be used with the HDevelopTemplate or
//  HDevelopTemplateWPF projects located under %HALCONEXAMPLES%\c#

using System;
using System.Windows.Forms;
using HalconDotNet;


namespace FlowerDetect
{

    public partial class HDevelopExport
    {
        public HTuple hv_ExpDefaultWinHandle;

        public void HDevelopStop()
        {
            MessageBox.Show("Press button to continue", "Program stop");
        }
        private bool index;
        // Main procedure 
        private HTuple action()
        {


            // Local iconic variables 
            HObject ho_Image,ho_ImageRotate, ho_GrayImage;
            HObject ho_ImageMedian, ho_Region, ho_ConnectedRegions;
            HObject ho_SelectedRegions, ho_SelectedRegions2, ho_SelectedRegions1;
            HObject ho_SelectedRegions3, ho_SortedRegions, ho_RegionUnion;
            HObject ho_Rectangle, ho_ImageReduced, ho_GrayImageA, ho_GragImageA;
            HObject ho_RegionsA_temp, ho_ConnectedRegionsA_temp, ho_SelectedRegionsA_temp;
            HObject ho_ImageAffineTrans, ho_RegionsA, ho_RegionDilationA;
            HObject ho_ConnectedRegionsA, ho_SelectedRegionsA, ho_RegionsA1;
            HObject ho_RegionOpeningA, ho_SelectedRegionsA1, ho_RegionUnionA;
            HObject ho_SelectedRegionsA2, ho_RegionsB, ho_ConnectedRegionsB;
            HObject ho_SelectedRegionsB, ho_RectangleB1, ho_RectangleB2;
            HObject ho_RegionDifferenceB, ho_ImageReducedB1, ho_RegionB1;
            HObject ho_ConnectedRegionsB2, ho_SelectedRegionsB2, ho_outContours;
            HObject ho_SelectedContours, ho_SortedContours, ho_Region1;
            HObject ho_ConnectedRegions1, ho_SelectedRegions4, ho_SelectedRegions5;
            HObject ho_SelectedRegions6, ho_Contours, ho_SortedContours3;
            HObject ho_obj = null, ho_objj = null, ho_ContoursSplit = null;
            HObject ho_SelectedXLD = null, ho_SortedContours1 = null, ho_M = null;
            HObject ho_Contour = null, ho_SelectedXLD1 = null, ho_SortedContours2 = null;
            HObject ho_ObjectSelectedB = null;

            // Local control variables 

            HTuple hv_NumberB = null, hv_Row1 = null, hv_Column1 = null;
            HTuple hv_Phi = null, hv_Length1 = null, hv_Length2 = null;
            HTuple hv_Phi_temp = null, hv_Area_temp = null, hv_Row_temp = null;
            HTuple hv_Column_temp = null, hv_HomMat2D = null, hv_RowA1 = null;
            HTuple hv_ColumnA1 = null, hv_RowA2 = null, hv_ColumnA2 = null;
            HTuple hv_RowA3 = null, hv_ColumnA3 = null, hv_RowA4 = null;
            HTuple hv_ColumnA4 = null, hv_RowB16 = null, hv_ColumnB16 = null;
            HTuple hv_PhiB3 = null, hv_LengthB1 = null, hv_LengthB2 = null;
            HTuple hv_AreaB = null, hv_RowB2 = null, hv_ColumnB2 = null;
            HTuple hv_Number = null, hv_Number3 = null, hv_A1 = null;
            HTuple hv_A2 = null, hv_B1 = null, hv_B2 = null, hv_C1 = null;
            HTuple hv_C2 = null, hv_C3 = null, hv_C4 = null, hv_i = null;
            HTuple hv_Ro1 = new HTuple(), hv_Co1 = new HTuple(), hv_MinBR = new HTuple();
            HTuple hv_MaxBR = new HTuple(), hv_MinBC = new HTuple();
            HTuple hv_MaxBC = new HTuple(), hv_BR = new HTuple(), hv_BC = new HTuple();
            HTuple hv_j = new HTuple(), hv_Number1 = new HTuple();
            HTuple hv_a = new HTuple(), hv_Ro2 = new HTuple(), hv_Co2 = new HTuple();
            HTuple hv_LUC = new HTuple(), hv_RUC = new HTuple(), hv_Ro3 = new HTuple();
            HTuple hv_Co3 = new HTuple(), hv_LDC = new HTuple(), hv_RDC = new HTuple();
            HTuple hv_RowBegin = new HTuple(), hv_ColBegin = new HTuple();
            HTuple hv_RowEnd = new HTuple(), hv_ColEnd = new HTuple();
            HTuple hv_Nr = new HTuple(), hv_Nc = new HTuple(), hv_Dist = new HTuple();
            HTuple hv_Rowc = new HTuple(), hv_Colc = new HTuple();
            HTuple hv_MeanR = new HTuple(), hv_H1 = new HTuple(), hv_H3 = new HTuple();
            HTuple hv_Number2 = new HTuple(), hv_b = new HTuple();
            HTuple hv_Ro4 = new HTuple(), hv_Co4 = new HTuple(), hv_LUR = new HTuple();
            HTuple hv_LDR = new HTuple(), hv_Ro5 = new HTuple(), hv_Co5 = new HTuple();
            HTuple hv_RUR = new HTuple(), hv_RDR = new HTuple(), hv_MeanC = new HTuple();
            HTuple hv_H4 = new HTuple(), hv_H2 = new HTuple(), hv_Distance1 = new HTuple();
            HTuple hv_Distance2 = new HTuple(), hv_AreaA = null, hv_RowA = null;
            HTuple hv_ColumnA = null, hv_phi = null, hv_paozhengwei = null;
            HTuple hv_k = null, hv_Indices = null, hv_liebo = null;
            HTuple hv_NumB = null, hv_count = null, hv_I = new HTuple();
            HTuple hv_AreaB1 = new HTuple(), hv_RowB3 = new HTuple();
            HTuple hv_ColumnB3 = new HTuple();
            // Initialize local and output iconic variables 
            HOperatorSet.GenEmptyObj(out ho_Image);
            HOperatorSet.GenEmptyObj(out ho_ImageRotate);
            HOperatorSet.GenEmptyObj(out ho_GrayImage);
            HOperatorSet.GenEmptyObj(out ho_ImageMedian);
            HOperatorSet.GenEmptyObj(out ho_Region);
            HOperatorSet.GenEmptyObj(out ho_ConnectedRegions);
            HOperatorSet.GenEmptyObj(out ho_SelectedRegions);
            HOperatorSet.GenEmptyObj(out ho_SelectedRegions2);
            HOperatorSet.GenEmptyObj(out ho_SelectedRegions1);
            HOperatorSet.GenEmptyObj(out ho_SelectedRegions3);
            HOperatorSet.GenEmptyObj(out ho_SortedRegions);
            HOperatorSet.GenEmptyObj(out ho_RegionUnion);
            HOperatorSet.GenEmptyObj(out ho_Rectangle);
            HOperatorSet.GenEmptyObj(out ho_ImageReduced);
            HOperatorSet.GenEmptyObj(out ho_GrayImageA);
            HOperatorSet.GenEmptyObj(out ho_GragImageA);
            HOperatorSet.GenEmptyObj(out ho_RegionsA_temp);
            HOperatorSet.GenEmptyObj(out ho_ConnectedRegionsA_temp);
            HOperatorSet.GenEmptyObj(out ho_SelectedRegionsA_temp);
            HOperatorSet.GenEmptyObj(out ho_ImageAffineTrans);
            HOperatorSet.GenEmptyObj(out ho_RegionsA);
            HOperatorSet.GenEmptyObj(out ho_RegionDilationA);
            HOperatorSet.GenEmptyObj(out ho_ConnectedRegionsA);
            HOperatorSet.GenEmptyObj(out ho_SelectedRegionsA);
            HOperatorSet.GenEmptyObj(out ho_RegionsA1);
            HOperatorSet.GenEmptyObj(out ho_RegionOpeningA);
            HOperatorSet.GenEmptyObj(out ho_SelectedRegionsA1);
            HOperatorSet.GenEmptyObj(out ho_RegionUnionA);
            HOperatorSet.GenEmptyObj(out ho_SelectedRegionsA2);
            HOperatorSet.GenEmptyObj(out ho_RegionsB);
            HOperatorSet.GenEmptyObj(out ho_ConnectedRegionsB);
            HOperatorSet.GenEmptyObj(out ho_SelectedRegionsB);
            HOperatorSet.GenEmptyObj(out ho_RectangleB1);
            HOperatorSet.GenEmptyObj(out ho_RectangleB2);
            HOperatorSet.GenEmptyObj(out ho_RegionDifferenceB);
            HOperatorSet.GenEmptyObj(out ho_ImageReducedB1);
            HOperatorSet.GenEmptyObj(out ho_RegionB1);
            HOperatorSet.GenEmptyObj(out ho_ConnectedRegionsB2);
            HOperatorSet.GenEmptyObj(out ho_SelectedRegionsB2);
            HOperatorSet.GenEmptyObj(out ho_outContours);
            HOperatorSet.GenEmptyObj(out ho_SelectedContours);
            HOperatorSet.GenEmptyObj(out ho_SortedContours);
            HOperatorSet.GenEmptyObj(out ho_Region1);
            HOperatorSet.GenEmptyObj(out ho_ConnectedRegions1);
            HOperatorSet.GenEmptyObj(out ho_SelectedRegions4);
            HOperatorSet.GenEmptyObj(out ho_SelectedRegions5);
            HOperatorSet.GenEmptyObj(out ho_SelectedRegions6);
            HOperatorSet.GenEmptyObj(out ho_Contours);
            HOperatorSet.GenEmptyObj(out ho_SortedContours3);
            HOperatorSet.GenEmptyObj(out ho_obj);
            HOperatorSet.GenEmptyObj(out ho_objj);
            HOperatorSet.GenEmptyObj(out ho_ContoursSplit);
            HOperatorSet.GenEmptyObj(out ho_SelectedXLD);
            HOperatorSet.GenEmptyObj(out ho_SortedContours1);
            HOperatorSet.GenEmptyObj(out ho_M);
            HOperatorSet.GenEmptyObj(out ho_Contour);
            HOperatorSet.GenEmptyObj(out ho_SelectedXLD1);
            HOperatorSet.GenEmptyObj(out ho_SortedContours2);
            HOperatorSet.GenEmptyObj(out ho_ObjectSelectedB);
            ho_Image.Dispose();
            if(!this.index)
            HOperatorSet.ReadImage(out ho_Image, "test.bmp");
            else
            HOperatorSet.ReadImage(out ho_Image, "PersonImg\\xiaosy.png");


            //*******************************************第一组预处理***********************************************
            ho_ImageRotate.Dispose();
            HOperatorSet.RotateImage(ho_Image, out ho_ImageRotate, 45, "constant");
            ho_GrayImage.Dispose();
            HOperatorSet.Rgb1ToGray(ho_ImageRotate, out ho_GrayImage);
            ho_ImageMedian.Dispose();
            HOperatorSet.MedianImage(ho_GrayImage, out ho_ImageMedian, "circle", 3, "mirrored");
            ho_Region.Dispose();
            HOperatorSet.Threshold(ho_GrayImage, out ho_Region, 200, 255);
            ho_ConnectedRegions.Dispose();
            HOperatorSet.Connection(ho_Region, out ho_ConnectedRegions);
            ho_SelectedRegions.Dispose();
            HOperatorSet.SelectShape(ho_ConnectedRegions, out ho_SelectedRegions, "area",
                "and", 150, 99999);
            ho_SelectedRegions2.Dispose();
            HOperatorSet.SelectShape(ho_SelectedRegions, out ho_SelectedRegions2, "circularity",
                "and", 0.37, 0.7);
            ho_SelectedRegions1.Dispose();
            HOperatorSet.ClosingRectangle1(ho_SelectedRegions2, out ho_SelectedRegions1,
                5, 5);
            ho_SelectedRegions3.Dispose();
            HOperatorSet.SelectShape(ho_SelectedRegions1, out ho_SelectedRegions3, "holes_num",
                "and", 1, 99);
            ho_SortedRegions.Dispose();
            HOperatorSet.SortRegion(ho_SelectedRegions3, out ho_SortedRegions, "first_point",
                "true", "column");
            HOperatorSet.CountObj(ho_SelectedRegions3, out hv_NumberB);
            ho_RegionUnion.Dispose();
            HOperatorSet.Union1(ho_SelectedRegions3, out ho_RegionUnion);
            HOperatorSet.SmallestRectangle2(ho_RegionUnion, out hv_Row1, out hv_Column1,
                out hv_Phi, out hv_Length1, out hv_Length2);
            ho_Rectangle.Dispose();
            HOperatorSet.GenRectangle2(out ho_Rectangle, hv_Row1, hv_Column1, hv_Phi, hv_Length1,
                hv_Length2);
            ho_ImageReduced.Dispose();
            HOperatorSet.ReduceDomain(ho_GrayImage, ho_Rectangle, out ho_ImageReduced);



            //*******************************************第二组预处理***********************************************
            ho_GrayImageA.Dispose();
            HOperatorSet.Rgb1ToGray(ho_Image, out ho_GrayImageA);
            ho_GragImageA.Dispose();
            HOperatorSet.GrayDilationRect(ho_GrayImageA, out ho_GragImageA, 4, 4);
            ho_RegionsA_temp.Dispose();
            HOperatorSet.Threshold(ho_GrayImageA, out ho_RegionsA_temp, 116, 218);
            ho_ConnectedRegionsA_temp.Dispose();
            HOperatorSet.Connection(ho_RegionsA_temp, out ho_ConnectedRegionsA_temp);
            ho_SelectedRegionsA_temp.Dispose();
            HOperatorSet.SelectShape(ho_ConnectedRegionsA_temp, out ho_SelectedRegionsA_temp,
                "area", "and", 108357, 495042);
            HOperatorSet.OrientationRegion(ho_SelectedRegionsA_temp, out hv_Phi_temp);
            HOperatorSet.AreaCenter(ho_SelectedRegionsA_temp, out hv_Area_temp, out hv_Row_temp,
                out hv_Column_temp);
            HOperatorSet.VectorAngleToRigid(hv_Row_temp, hv_Column_temp, hv_Phi_temp, hv_Row_temp,
                hv_Column_temp, (new HTuple(0)).TupleRad(), out hv_HomMat2D);
            ho_ImageAffineTrans.Dispose();
            HOperatorSet.AffineTransImage(ho_GrayImageA, out ho_ImageAffineTrans, hv_HomMat2D,
                "constant", "false");
            ho_RegionsA.Dispose();
            HOperatorSet.Threshold(ho_ImageAffineTrans, out ho_RegionsA, 116, 218);
            ho_RegionDilationA.Dispose();
            HOperatorSet.DilationRectangle1(ho_RegionsA, out ho_RegionDilationA, 2, 2);
            ho_ConnectedRegionsA.Dispose();
            HOperatorSet.Connection(ho_RegionDilationA, out ho_ConnectedRegionsA);
            ho_SelectedRegionsA.Dispose();
            HOperatorSet.SelectShape(ho_ConnectedRegionsA, out ho_SelectedRegionsA, "circularity",
                "and", 0.001, 0.03);
            ho_RegionsA1.Dispose();
            HOperatorSet.Threshold(ho_GrayImageA, out ho_RegionsA1, 227, 255);
            ho_RegionOpeningA.Dispose();
            HOperatorSet.OpeningCircle(ho_RegionsA1, out ho_RegionOpeningA, 5.5);
            ho_ConnectedRegionsA.Dispose();
            HOperatorSet.Connection(ho_RegionOpeningA, out ho_ConnectedRegionsA);
            ho_SelectedRegionsA1.Dispose();
            HOperatorSet.SelectShape(ho_ConnectedRegionsA, out ho_SelectedRegionsA1, "row",
                "and", 513.2, 601.23);
            ho_RegionUnionA.Dispose();
            HOperatorSet.Union1(ho_SelectedRegionsA1, out ho_RegionUnionA);
            HOperatorSet.SmallestRectangle1(ho_RegionUnionA, out hv_RowA1, out hv_ColumnA1,
                out hv_RowA2, out hv_ColumnA2);
            ho_SelectedRegionsA2.Dispose();
            HOperatorSet.SelectShape(ho_ConnectedRegionsA, out ho_SelectedRegionsA2, "width",
                "and", 92.694, 100);
            HOperatorSet.InnerRectangle1(ho_SelectedRegionsA2, out hv_RowA3, out hv_ColumnA3,
                out hv_RowA4, out hv_ColumnA4);
            ho_ConnectedRegionsA.Dispose();
            HOperatorSet.Connection(ho_RegionsA1, out ho_ConnectedRegionsA);



            //*******************************************第三组预处理*********************************************
            ho_RegionsB.Dispose();
            HOperatorSet.Threshold(ho_Image, out ho_RegionsB, 131, 153);
            ho_ConnectedRegionsB.Dispose();
            HOperatorSet.Connection(ho_RegionsB, out ho_ConnectedRegionsB);
            ho_SelectedRegionsB.Dispose();
            HOperatorSet.SelectShapeStd(ho_ConnectedRegionsB, out ho_SelectedRegionsB, "max_area",
                70);
            HOperatorSet.SmallestRectangle2(ho_SelectedRegionsB, out hv_RowB16, out hv_ColumnB16,
                out hv_PhiB3, out hv_LengthB1, out hv_LengthB2);
            ho_RectangleB1.Dispose();
            HOperatorSet.GenRectangle2(out ho_RectangleB1, hv_RowB16 - 5, hv_ColumnB16, hv_PhiB3,
                hv_LengthB1 - 5, hv_LengthB2 - 5);
            ho_RectangleB2.Dispose();
            HOperatorSet.GenRectangle2(out ho_RectangleB2, hv_RowB16 - 3, hv_ColumnB16, hv_PhiB3,
                hv_LengthB1 - 5, hv_LengthB2 - 18);
            ho_RegionDifferenceB.Dispose();
            HOperatorSet.Difference(ho_RectangleB1, ho_RectangleB2, out ho_RegionDifferenceB
                );
            ho_ImageReducedB1.Dispose();
            HOperatorSet.ReduceDomain(ho_Image, ho_RegionDifferenceB, out ho_ImageReducedB1
                );
            ho_RegionB1.Dispose();
            HOperatorSet.Threshold(ho_ImageReducedB1, out ho_RegionB1, 200, 255);
            ho_ConnectedRegionsB2.Dispose();
            HOperatorSet.Connection(ho_RegionB1, out ho_ConnectedRegionsB2);
            ho_SelectedRegionsB2.Dispose();
            HOperatorSet.SelectShape(ho_ConnectedRegionsB2, out ho_SelectedRegionsB2, "area",
                "and", 26.01, 200);
            HOperatorSet.AreaCenter(ho_SelectedRegionsB2, out hv_AreaB, out hv_RowB2, out hv_ColumnB2);


            //*****************************************花瓣ABC**************************************************

            //边缘轮廓检测
            ho_outContours.Dispose();
            HOperatorSet.GenContourRegionXld(ho_SelectedRegions3, out ho_outContours, "border");
            ho_SelectedContours.Dispose();
            HOperatorSet.SelectContoursXld(ho_outContours, out ho_SelectedContours, "contour_length",
                60, 600, -0.5, 0.5);
            ho_SortedContours.Dispose();
            HOperatorSet.SortContoursXld(ho_SelectedContours, out ho_SortedContours, "upper_left",
                "true", "column");
            HOperatorSet.CountObj(ho_SortedContours, out hv_Number);

            //中心轮廓检测
            ho_Region1.Dispose();
            HOperatorSet.Threshold(ho_ImageReduced, out ho_Region1, 0, 135);
            ho_ConnectedRegions1.Dispose();
            HOperatorSet.Connection(ho_Region1, out ho_ConnectedRegions1);
            ho_SelectedRegions4.Dispose();
            HOperatorSet.SelectShape(ho_ConnectedRegions1, out ho_SelectedRegions4, "area",
                "and", 230, 600);
            ho_SelectedRegions5.Dispose();
            HOperatorSet.SelectShape(ho_SelectedRegions4, out ho_SelectedRegions5, "ratio",
                "and", 0.7, 1.352);
            ho_SelectedRegions6.Dispose();
            HOperatorSet.SelectShape(ho_SelectedRegions5, out ho_SelectedRegions6, "circularity",
                "and", 0.2, 1);
            ho_Contours.Dispose();
            HOperatorSet.GenContourRegionXld(ho_SelectedRegions6, out ho_Contours, "border");
            ho_SortedContours3.Dispose();
            HOperatorSet.SortContoursXld(ho_Contours, out ho_SortedContours3, "upper_left",
                "true", "row");
            HOperatorSet.CountObj(ho_SortedContours3, out hv_Number3);


            if ((int)(new HTuple((((hv_Number + hv_Number3) % 2)).TupleEqual(1))) != 0)
            {

                //这里需要在C#输出无法检测的信息
                HDevelopStop();
            }



            //里面的轮廓 A1左上到右下 A2左下到右上
            hv_A1 = new HTuple();
            hv_A2 = new HTuple();
            //外面的轮廓 B1垂直方向 B2水平方向
            hv_B1 = new HTuple();
            hv_B2 = new HTuple();
            //c1到c4顺时针顺序的四个花瓣长度
            hv_C1 = new HTuple();
            hv_C2 = new HTuple();
            hv_C3 = new HTuple();
            hv_C4 = new HTuple();


            //B的检测
            HTuple end_val103 = hv_Number;
            HTuple step_val103 = 1;
            for (hv_i = 1; hv_i.Continue(end_val103, step_val103); hv_i = hv_i.TupleAdd(step_val103))
            {
                ho_obj.Dispose();
                HOperatorSet.SelectObj(ho_SortedContours, out ho_obj, hv_i);
                HOperatorSet.GetContourXld(ho_obj, out hv_Ro1, out hv_Co1);
                HOperatorSet.TupleMin(hv_Ro1, out hv_MinBR);
                HOperatorSet.TupleMax(hv_Ro1, out hv_MaxBR);
                HOperatorSet.TupleMin(hv_Co1, out hv_MinBC);
                HOperatorSet.TupleMax(hv_Co1, out hv_MaxBC);
                hv_BR = hv_MaxBR - hv_MinBR;
                hv_BC = hv_MaxBC - hv_MinBC;
                hv_B1 = hv_B1.TupleConcat(hv_BR);
                hv_B2 = hv_B2.TupleConcat(hv_BC);



                //A的检测
                HTuple end_val118 = hv_Number3;
                HTuple step_val118 = 1;
                for (hv_j = 1; hv_j.Continue(end_val118, step_val118); hv_j = hv_j.TupleAdd(step_val118))
                {
                    if ((int)(new HTuple(hv_i.TupleEqual(hv_j))) != 0)
                    {
                        ho_objj.Dispose();
                        HOperatorSet.SelectObj(ho_SortedContours3, out ho_objj, hv_j);




                        //C的检测
                        ho_ContoursSplit.Dispose();
                        HOperatorSet.SegmentContoursXld(ho_objj, out ho_ContoursSplit, "lines",
                            5, 4, 2);
                        ho_SelectedXLD.Dispose();
                        HOperatorSet.SelectShapeXld(ho_ContoursSplit, out ho_SelectedXLD, "width",
                            "and", 13, 99);
                        ho_SortedContours1.Dispose();
                        HOperatorSet.SortContoursXld(ho_SelectedXLD, out ho_SortedContours1, "upper_left",
                            "true", "row");
                        HOperatorSet.CountObj(ho_SortedContours1, out hv_Number1);
                        HTuple end_val130 = hv_Number1;
                        HTuple step_val130 = 1;
                        for (hv_a = 1; hv_a.Continue(end_val130, step_val130); hv_a = hv_a.TupleAdd(step_val130))
                        {
                            ho_M.Dispose();
                            HOperatorSet.SelectObj(ho_SortedContours1, out ho_M, hv_a);
                            if ((int)(new HTuple(hv_a.TupleEqual(1))) != 0)
                            {
                                HOperatorSet.GetContourXld(ho_M, out hv_Ro2, out hv_Co2);
                                HOperatorSet.TupleMin(hv_Co2, out hv_LUC);
                                HOperatorSet.TupleMax(hv_Co2, out hv_RUC);
                            }
                            else
                            {
                                HOperatorSet.GetContourXld(ho_M, out hv_Ro3, out hv_Co3);
                                HOperatorSet.TupleMin(hv_Co3, out hv_LDC);
                                HOperatorSet.TupleMax(hv_Co3, out hv_RDC);
                            }
                            HOperatorSet.FitLineContourXld(ho_M, "huber", -1, 0, 5, 2, out hv_RowBegin,
                                out hv_ColBegin, out hv_RowEnd, out hv_ColEnd, out hv_Nr, out hv_Nc,
                                out hv_Dist);
                            ho_Contour.Dispose();
                            HOperatorSet.GenContourPolygonXld(out ho_Contour, hv_RowBegin.TupleConcat(
                                hv_RowEnd), hv_ColBegin.TupleConcat(hv_ColEnd));
                            HOperatorSet.GetContourXld(ho_Contour, out hv_Rowc, out hv_Colc);
                            HOperatorSet.TupleMean(hv_Rowc, out hv_MeanR);
                            if ((int)(new HTuple(hv_a.TupleEqual(1))) != 0)
                            {
                                hv_H1 = hv_MeanR - hv_MinBR;
                                hv_C1 = hv_C1.TupleConcat(hv_H1);
                            }
                            else
                            {
                                hv_H3 = hv_MaxBR - hv_MeanR;
                                hv_C3 = hv_C3.TupleConcat(hv_H3);
                            }
                        }

                        ho_SelectedXLD1.Dispose();
                        HOperatorSet.SelectShapeXld(ho_ContoursSplit, out ho_SelectedXLD1, "height",
                            "and", 13, 99);
                        ho_SortedContours2.Dispose();
                        HOperatorSet.SortContoursXld(ho_SelectedXLD1, out ho_SortedContours2, "upper_left",
                            "true", "column");
                        HOperatorSet.CountObj(ho_SortedContours2, out hv_Number2);
                        HTuple end_val157 = hv_Number2;
                        HTuple step_val157 = 1;
                        for (hv_b = 1; hv_b.Continue(end_val157, step_val157); hv_b = hv_b.TupleAdd(step_val157))
                        {
                            ho_M.Dispose();
                            HOperatorSet.SelectObj(ho_SortedContours2, out ho_M, hv_b);
                            if ((int)(new HTuple(hv_b.TupleEqual(1))) != 0)
                            {
                                HOperatorSet.GetContourXld(ho_M, out hv_Ro4, out hv_Co4);
                                HOperatorSet.TupleMin(hv_Ro4, out hv_LUR);
                                HOperatorSet.TupleMax(hv_Ro4, out hv_LDR);
                            }
                            else
                            {
                                HOperatorSet.GetContourXld(ho_M, out hv_Ro5, out hv_Co5);
                                HOperatorSet.TupleMin(hv_Ro5, out hv_RUR);
                                HOperatorSet.TupleMax(hv_Ro5, out hv_RDR);
                            }
                            HOperatorSet.FitLineContourXld(ho_M, "huber", -1, 0, 5, 2, out hv_RowBegin,
                                out hv_ColBegin, out hv_RowEnd, out hv_ColEnd, out hv_Nr, out hv_Nc,
                                out hv_Dist);
                            ho_Contour.Dispose();
                            HOperatorSet.GenContourPolygonXld(out ho_Contour, hv_RowBegin.TupleConcat(
                                hv_RowEnd), hv_ColBegin.TupleConcat(hv_ColEnd));
                            HOperatorSet.GetContourXld(ho_Contour, out hv_Rowc, out hv_Colc);
                            HOperatorSet.TupleMean(hv_Colc, out hv_MeanC);
                            if ((int)(new HTuple(hv_b.TupleEqual(1))) != 0)
                            {
                                hv_H4 = hv_MeanC - hv_MinBC;
                                hv_C4 = hv_C4.TupleConcat(hv_H4);
                            }
                            else
                            {
                                hv_H2 = hv_MaxBC - hv_MeanC;
                                hv_C2 = hv_C2.TupleConcat(hv_H2);
                            }
                        }

                        HOperatorSet.DistancePp(hv_LUC, hv_LUR, hv_RDC, hv_RDR, out hv_Distance1);
                        HOperatorSet.DistancePp(hv_RUC, hv_RUR, hv_LDC, hv_LDR, out hv_Distance2);
                        hv_A1 = hv_A1.TupleConcat(hv_Distance1);
                        hv_A2 = hv_A2.TupleConcat(hv_Distance2);


                    }
                }

            }

            //*********************************倾斜角度 跑针位 k*******************************************
            HOperatorSet.AreaCenter(ho_SelectedRegionsA, out hv_AreaA, out hv_RowA, out hv_ColumnA);
            HOperatorSet.OrientationRegion(ho_SelectedRegionsA, out hv_Phi);
            hv_Phi = hv_Phi.TupleDeg();
            hv_phi = ((90 - (hv_Phi.TupleAbs()))).TupleAbs();
            hv_paozhengwei = (hv_RowA3 - ((hv_RowA2 / 2) + (hv_RowA1 / 2))) - 4;
            hv_k = (hv_RowA2 - hv_RowA1) + 4;



            //***************************************裂箔****************************************************
            HOperatorSet.TupleSortIndex(hv_AreaB, out hv_Indices);
            hv_liebo = new HTuple();
            hv_NumB = new HTuple(hv_Indices.TupleLength());
            hv_count = 0;
            if ((int)(new HTuple(hv_NumB.TupleGreater(0))) != 0)
            {
                HTuple end_val208 = hv_NumB;
                HTuple step_val208 = 1;
                for (hv_I = 1; hv_I.Continue(end_val208, step_val208); hv_I = hv_I.TupleAdd(step_val208))
                {
                    ho_ObjectSelectedB.Dispose();
                    HOperatorSet.SelectObj(ho_SelectedRegionsB2, out ho_ObjectSelectedB, hv_I);
                    HOperatorSet.AreaCenter(ho_ObjectSelectedB, out hv_AreaB1, out hv_RowB3,
                        out hv_ColumnB3);
                    if ((int)(new HTuple(hv_AreaB1.TupleGreater(30))) != 0)
                    {
                        hv_count = hv_count + 1;
                    }
                    else
                    {

                    }
                }
            }
            else
            {
            }
            if (hv_liebo == null)
                hv_liebo = new HTuple();
            hv_liebo[0] = hv_count;

            HTuple result = new HTuple();
            result.Append(hv_A1[0]);
            result.Append(hv_A2[0]);
            result.Append(hv_B1[0]);
            result.Append(hv_B2[0]);
            result.Append(hv_C1[0]);
            result.Append(hv_C2[0]);
            result.Append(hv_C3[0]);
            result.Append(hv_C4[0]);

            result.Append(hv_phi[0]);
            result.Append(hv_paozhengwei[0]);
            result.Append(hv_liebo[0]);
            
         


            //**************************************************************************************************



            ho_Image.Dispose();
            ho_ImageRotate.Dispose();
            ho_GrayImage.Dispose();
            ho_ImageMedian.Dispose();
            ho_Region.Dispose();
            ho_ConnectedRegions.Dispose();
            ho_SelectedRegions.Dispose();
            ho_SelectedRegions2.Dispose();
            ho_SelectedRegions1.Dispose();
            ho_SelectedRegions3.Dispose();
            ho_SortedRegions.Dispose();
            ho_RegionUnion.Dispose();
            ho_Rectangle.Dispose();
            ho_ImageReduced.Dispose();
            ho_GrayImageA.Dispose();
            ho_GragImageA.Dispose();
            ho_RegionsA_temp.Dispose();
            ho_ConnectedRegionsA_temp.Dispose();
            ho_SelectedRegionsA_temp.Dispose();
            ho_ImageAffineTrans.Dispose();
            ho_RegionsA.Dispose();
            ho_RegionDilationA.Dispose();
            ho_ConnectedRegionsA.Dispose();
            ho_SelectedRegionsA.Dispose();
            ho_RegionsA1.Dispose();
            ho_RegionOpeningA.Dispose();
            ho_SelectedRegionsA1.Dispose();
            ho_RegionUnionA.Dispose();
            ho_SelectedRegionsA2.Dispose();
            ho_RegionsB.Dispose();
            ho_ConnectedRegionsB.Dispose();
            ho_SelectedRegionsB.Dispose();
            ho_RectangleB1.Dispose();
            ho_RectangleB2.Dispose();
            ho_RegionDifferenceB.Dispose();
            ho_ImageReducedB1.Dispose();
            ho_RegionB1.Dispose();
            ho_ConnectedRegionsB2.Dispose();
            ho_SelectedRegionsB2.Dispose();
            ho_outContours.Dispose();
            ho_SelectedContours.Dispose();
            ho_SortedContours.Dispose();
            ho_Region1.Dispose();
            ho_ConnectedRegions1.Dispose();
            ho_SelectedRegions4.Dispose();
            ho_SelectedRegions5.Dispose();
            ho_SelectedRegions6.Dispose();
            ho_Contours.Dispose();
            ho_SortedContours3.Dispose();
            ho_obj.Dispose();
            ho_objj.Dispose();
            ho_ContoursSplit.Dispose();
            ho_SelectedXLD.Dispose();
            ho_SortedContours1.Dispose();
            ho_M.Dispose();
            ho_Contour.Dispose();
            ho_SelectedXLD1.Dispose();
            ho_SortedContours2.Dispose();
            ho_ObjectSelectedB.Dispose();
            return result;
        }

        public void InitHalcon()
        {
            // Default settings used in HDevelop 
            HOperatorSet.SetSystem("width", 512);
            HOperatorSet.SetSystem("height", 512);
        }

        public HTuple RunHalcon(bool x)
        {

            this.index = x;
            //hv_ExpDefaultWinHandle = Window;
            return action();
           
            
        }

    }
}



