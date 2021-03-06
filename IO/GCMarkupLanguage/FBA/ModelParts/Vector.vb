﻿#Region "Microsoft.VisualBasic::aed81d244a8b231cd0aee55939905491, engine\IO\GCMarkupLanguage\FBA\ModelParts\Vector.vb"

    ' Author:
    ' 
    '       asuka (amethyst.asuka@gcmodeller.org)
    '       xie (genetics@smrucc.org)
    '       xieguigang (xie.guigang@live.com)
    ' 
    ' Copyright (c) 2018 GPL3 Licensed
    ' 
    ' 
    ' GNU GENERAL PUBLIC LICENSE (GPL3)
    ' 
    ' 
    ' This program is free software: you can redistribute it and/or modify
    ' it under the terms of the GNU General Public License as published by
    ' the Free Software Foundation, either version 3 of the License, or
    ' (at your option) any later version.
    ' 
    ' This program is distributed in the hope that it will be useful,
    ' but WITHOUT ANY WARRANTY; without even the implied warranty of
    ' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    ' GNU General Public License for more details.
    ' 
    ' You should have received a copy of the GNU General Public License
    ' along with this program. If not, see <http://www.gnu.org/licenses/>.



    ' /********************************************************************************/

    ' Summaries:

    '     Class Vector
    ' 
    '         Properties: Identifier, InitializeAmount
    ' 
    '         Function: ToString
    ' 
    ' 
    ' /********************************************************************************/

#End Region

Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.ComponentModel
Imports Microsoft.VisualBasic.Extensions
Imports Microsoft.VisualBasic.Net.Protocols
Imports SMRUCC.genomics.Model.SBML

Namespace FBACompatibility

    Public Class Vector : Inherits Streams.Array.Double
        Implements FLuxBalanceModel.IMetabolite

        ''' <summary>
        ''' The Unique ID property for the metabolite.
        ''' </summary>
        ''' <remarks></remarks>
        <XmlAttribute> Public Property Identifier As String Implements FLuxBalanceModel.IMetabolite.Key

        Public Overrides Function ToString() As String
            Return Identifier
        End Function

        <XmlAttribute>
        Public Property InitializeAmount As Double Implements FLuxBalanceModel.IMetabolite.InitializeAmount
    End Class
End Namespace
