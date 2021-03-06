// PriceStyle.h: interface for the CPriceStyle class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_PRICESTYLEKAGI_H__E5248285_966F_4CEC_BE4D_78699034A3B4__INCLUDED_)
#define AFX_PRICESTYLEKAGI_H__E5248285_966F_4CEC_BE4D_78699034A3B4__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#include "PriceStyle.h"

class CChartPanel;
class CStockChartXCtrl;


class CPriceStyleKagi : public CPriceStyle
{
public:
	CPriceStyleKagi::CPriceStyleKagi();
	virtual ~CPriceStyleKagi();		
	void OnPaint(CDC* pDC);
	void Connect(CStockChartXCtrl *Ctrl, CSeries* Series);
	bool connected;

private:	

	void PaintBar(CDC* pDC, int x, double space,
						double top, double bottom, 
						int direction, int index,
						int weight,
						double changePrice);

};




#endif // !defined(AFX_PRICESTYLEKAGI_H__E5248285_966F_4CEC_BE4D_78699034A3B4__INCLUDED_)
