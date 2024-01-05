#pragma once

#include "gmock/gmock.h"

#include "IArmour.h"

namespace DnD {

class ArmourMock
    : public IArmour
{
public:
    MOCK_METHOD(int, modifyAttack, (int), (const, override));
};

} // namespace DnD