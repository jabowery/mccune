#!/bin/csh

foreach i ( [A-Z]*.in )

    echo Starting $i

    mccune -f cs.in $i > $i:r-cs.outu

end
